using AutoMapper;
using Business.Dtos.User;
using Business.Requests.User;
using Business.Responses.User;
using Core.Entities;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class UserMapperProfiles : Profile
    {
        public UserMapperProfiles()
        {
            CreateMap<AddUserRequest, User>();
            CreateMap<User, AddUserResponse>();
            CreateMap<User, UserListItemDto>();
            CreateMap<IList<User>, GetUserListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            CreateMap<User, DeleteUserResponse>();
            CreateMap<User, GetUserByIdResponse>();
            CreateMap<UpdateUserRequest, User>();
            CreateMap<User, UpdateUserResponse>();
            
        }
    }
}