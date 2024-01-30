using Business.Request.Customer;
using Business.Responses.Customer;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public AddCustomerResponse Add(AddCustomerRequest request);
        public DeleteCustomerResponse Delete(DeleteCustomerRequest request);
        public UpdateCustomerResponse Update(UpdateCustomerRequest request);
        public GetCustomerListResponse GetList(GetCustomerListRequest request);
        public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request);

    }
}
