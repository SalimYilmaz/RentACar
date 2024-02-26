namespace Business.Requests.CorporateCustomer
{
    public class UpdateCorporateCustomerRequest
    {
        public UpdateCorporateCustomerRequest(int ıd, string companyName, string taxNo, int customerId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            CustomerId = customerId;
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public int CustomerId { get; set; }
    }
}