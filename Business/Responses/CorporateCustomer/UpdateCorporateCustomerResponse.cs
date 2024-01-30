namespace Business.Responses.CorporateCustomer
{
    public class UpdateCorporateCustomerResponse
    {
        public UpdateCorporateCustomerResponse(int ıd, string companyName, string taxNo, DateTime updatedAt, int customerId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            UpdatedAt = updatedAt;
            CustomerId = customerId;
        }
        public UpdateCorporateCustomerResponse()
        {

        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CustomerId { get; set; }
    }
}