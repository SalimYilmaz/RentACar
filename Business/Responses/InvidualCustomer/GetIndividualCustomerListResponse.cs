using Business.Dtos.IndividualCustomer;

namespace Business.Responses.IndividualCustomer
{
    public class GetIndividualCustomerListResponse
    {
        public GetIndividualCustomerListResponse(ICollection<IndividualCustomerListItemDto> ıtems)
        {
            Items = ıtems;
        }
        public GetIndividualCustomerListResponse()
        {
            Items = Array.Empty<IndividualCustomerListItemDto>();
        }

        public ICollection<IndividualCustomerListItemDto> Items { get; set; }
    }
}