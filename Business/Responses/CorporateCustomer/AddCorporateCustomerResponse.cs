namespace Business.Responses.CorporateCustomer
{
    public class AddCorporateCustomerResponse
    {
        public AddCorporateCustomerResponse(int ıd, string companyName, string taxNo, DateTime createdAt, int customerId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            CreatedAt = createdAt;
            CustomerId = customerId;
        }
        public AddCorporateCustomerResponse()
        {

        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}