using Business.Dtos.CorporateCustomer;

namespace Business.Responses.CorporateCustomer
{
    public class GetCorporateCustomerListResponse
    {
        public GetCorporateCustomerListResponse(ICollection<CorporateCustomerListItemDto> ıtems)
        {
            Items = ıtems;
        }
        public GetCorporateCustomerListResponse()
        {
            Items = Array.Empty<CorporateCustomerListItemDto>();
        }
        public ICollection<CorporateCustomerListItemDto> Items { get; set; }

    }
}