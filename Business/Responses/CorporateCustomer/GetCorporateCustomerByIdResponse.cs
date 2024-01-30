namespace Business.Responses.CorporateCustomer
{
    public class GetCorporateCustomerByIdResponse
    {
        public GetCorporateCustomerByIdResponse(int ıd, string companyName, string taxNo, int customerId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            CustomerId = customerId;
        }
        public GetCorporateCustomerByIdResponse()
        {

        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public int CustomerId { get; set; }
    }
}