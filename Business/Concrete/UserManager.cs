using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.User;
using Business.Requests.User;
using Business.Responses.User;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Entities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;


namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly UserBusinessRules _businessRules;
        private IMapper _mapper;
        private readonly ITokenHelper _tokenHelper;

    
        public UserManager(IUserDal userDal, UserBusinessRules businessRules, IMapper mapper, ITokenHelper tokenHelper)
        {
            _userDal = userDal;
            _businessRules = businessRules;
            _mapper = mapper;
            _tokenHelper = tokenHelper;
        }

        public AccessToken Login(LoginRequest request)
        {
            User? user = _userDal.Get(i => i.Email == request.Email);
            // Business Rules...
            

            bool isPasswordCorrect = HashingHelper.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);
            if (!isPasswordCorrect)
                throw new Exception("Şifre yanlış.");
            return _tokenHelper.CreateToken(user);
        }

        public void Register(RegisterRequest request)
        {
            byte[] passwordSalt, passwordHash;
            HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

            // TODO: Auto-Mapping
            User user = new User();
            user.Email = request.Email;
            user.Approved = false;
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;
            

            _userDal.Add(user);
        }

        public AddUserResponse Add(AddUserRequest request)
        {
            ValidationTool.Validate(new AddUserRequestValidator(), request);
            User userToAdd = _mapper.Map<User>(request);
            _userDal.Add(userToAdd);
            AddUserResponse response = _mapper.Map<AddUserResponse>(userToAdd);
            return response;
        }

        public DeleteUserResponse Delete(DeleteUserRequest request)
        {
            User? userToDelete = _userDal.Get(predicate: user => user.Id == request.Id);
            _businessRules.CheckIfUserExists(userToDelete);
            User deletedUser = _userDal.Delete(userToDelete!);
            DeleteUserResponse response = _mapper.Map<DeleteUserResponse>(deletedUser);
            return response;
        }

        public GetUserListResponse GetList(GetUserListRequest request)
        {
            IList<User> userList = _userDal.GetList();
            GetUserListResponse response = _mapper.Map<GetUserListResponse>(userList);
            return response;
        }

        public GetUserByIdResponse GetById(GetUserByIdRequest request)
        {
            User? user = _userDal.Get(predicate: user => user.Id == request.Id);
            GetUserByIdResponse response = _mapper.Map<GetUserByIdResponse>(user);
            return response;
        }

        public UpdateUserResponse Update(UpdateUserRequest request)
        {
            User? userToUpdate = _userDal.Get(predicate: user => user.Id == request.Id);
            _businessRules.CheckIfUserExists(userToUpdate);
            userToUpdate = _mapper.Map(request, userToUpdate);
            User updatedUser = _userDal.Update(userToUpdate!);
            var response = _mapper.Map<UpdateUserResponse>(updatedUser);
            return response;
        }       

    }
}