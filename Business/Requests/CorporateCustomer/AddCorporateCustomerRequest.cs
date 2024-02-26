namespace Business.Requests.CorporateCustomer
{
    public class AddCorporateCustomerRequest
    {
        public AddCorporateCustomerRequest(string companyName, string taxNo, int customerId)
        {
            CompanyName = companyName;
            TaxNo = taxNo;
            CustomerId = customerId;
        }

        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public int CustomerId { get; set; }
    }
}