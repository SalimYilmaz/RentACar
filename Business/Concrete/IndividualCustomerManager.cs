using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class IndividualCustomerManager : IIndividualCustomerService
    {
        private readonly IIndividualCustomerDal _ındividualCustomerDal;
        private readonly IndividualCustomerBusinessRules _businessRules;
        private IMapper _mapper;

        public IndividualCustomerManager(IIndividualCustomerDal ındividualCustomerDal, IndividualCustomerBusinessRules businessRules, IMapper mapper)
        {
            _ındividualCustomerDal = ındividualCustomerDal;
            _businessRules = businessRules;
            _mapper = mapper;
        }

        public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request)
        {
            ValidationTool.Validate(new AddIndividualCustomerRequestValidator(), request);

            IndividualCustomer indivToAdd = _mapper.Map<IndividualCustomer>(request);
            _ındividualCustomerDal.Add(indivToAdd);
            AddIndividualCustomerResponse response = _mapper.Map<AddIndividualCustomerResponse>(indivToAdd);
            return response;
        }

        public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request)
        {
            IndividualCustomer? indivToDelete = _ındividualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _businessRules.CheckIfIndividualCustomerExists(indivToDelete);
            IndividualCustomer deletedIndiv = _ındividualCustomerDal.Delete(indivToDelete!);
            DeleteIndividualCustomerResponse response = _mapper.Map<DeleteIndividualCustomerResponse>(deletedIndiv);
            return response;

        }

        public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request)
        {
            IndividualCustomer? indiv = _ındividualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _businessRules.CheckIfIndividualCustomerExists(indiv);
            GetIndividualCustomerByIdResponse response = _mapper.Map<GetIndividualCustomerByIdResponse>(indiv);
            return response;
        }

        public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request)
        {
            IList<IndividualCustomer> indivList = _ındividualCustomerDal.GetList(
                predicate: indiv => (request.FilterByCustomerId == null || indiv.CustomerId == request.FilterByCustomerId));


            GetIndividualCustomerListResponse response = _mapper.Map<GetIndividualCustomerListResponse>(indivList);
            return response;
        }

        public UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request)
        {
            IndividualCustomer? indivToUpdate = _ındividualCustomerDal.Get(predicate: ind => ind.Id == request.Id);
            _businessRules.CheckIfIndividualCustomerExists(indivToUpdate);

            indivToUpdate = _mapper.Map(request, indivToUpdate);
            IndividualCustomer updatedIndiv = _ındividualCustomerDal.Update(indivToUpdate!);
            var response = _mapper.Map<UpdateIndividualCustomerResponse>(updatedIndiv);
            return response;
        }
    }
}