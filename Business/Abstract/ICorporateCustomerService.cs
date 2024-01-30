using Business.Request.CorporateCustomer;
using Business.Responses.CorporateCustomer;

namespace Business.Abstract
{
    public interface ICorporateCustomerService
    {
        public AddCorporateCustomerResponse Add(AddCorporateCustomerRequest request);
        public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request);
        public UpdateCorporateCustomerResponse Update(UpdateCorporateCustomerRequest request);
        public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request);
        public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request);

    }
}
