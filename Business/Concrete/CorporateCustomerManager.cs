using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.CorporateCustomer;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CorporateCustomerManager : ICorporateCustomerService
{
    private readonly ICorporateCustomerDal _corporateCustomerDal;
    private readonly CorporateCustomerBusinessRules _corporateCustomerBusinessRules;
    private IMapper _mapper;

    public CorporateCustomerManager(ICorporateCustomerDal corporateCustomerDal, CorporateCustomerBusinessRules corporateCustomerBusinessRules, IMapper mapper)
    {
        _corporateCustomerDal = corporateCustomerDal;
        _corporateCustomerBusinessRules = corporateCustomerBusinessRules;
        _mapper = mapper;
    }

    public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request)
    {
        ValidationTool.Validate(new AddCorporateCustomerRequestValidator(), request);
        CorporateCustomer corporateToAdd = _mapper.Map<CorporateCustomer>(request);
        _corporateCustomerDal.Add(corporateToAdd);
        AddCorporateCustomerResponse response = _mapper.Map<AddCorporateCustomerResponse>(request);
        return response;
    }

    public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request)
    {
        CorporateCustomer? corporateTodelete = _corporateCustomerDal.Get(predicate: corp => corp.Id == request.Id);
        _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corporateTodelete);
        CorporateCustomer deletedCorp = _corporateCustomerDal.Delete(corporateTodelete!);
        DeleteCorporateCustomerResponse response = _mapper.Map<DeleteCorporateCustomerResponse>(request);
        return response;
    }

    public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request)
    {
        CorporateCustomer? corp = _corporateCustomerDal.Get(predicate: corp => corp.Id == request.Id);
        _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corp);
        GetCorporateCustomerByIdResponse response = _mapper.Map<GetCorporateCustomerByIdResponse>(request);
        return response;
    }

    public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request)
    {
        IList<CorporateCustomer> corpList = _corporateCustomerDal.GetList(
            predicate: corp => (request.FilterByCustomerId == null || corp.CustomerId == request.FilterByCustomerId));
        GetCorporateCustomerListResponse response = _mapper.Map<GetCorporateCustomerListResponse>(corpList);
        return response;
    }

    public UpdateCorporateCustomerResponse Update(UpdateCorporateCustomerRequest request)
    {
        CorporateCustomer? corpToUpdate = _corporateCustomerDal.Get(predicate: corp => corp.Id == request.Id);
        _corporateCustomerBusinessRules.CheckIfCorporateCustomerExists(corpToUpdate);
        corpToUpdate = _mapper.Map(request, corpToUpdate);
        CorporateCustomer updatedCorp = _corporateCustomerDal.Update(corpToUpdate!);
        var response = _mapper.Map<UpdateCorporateCustomerResponse>(updatedCorp);
        return response;
    }
}