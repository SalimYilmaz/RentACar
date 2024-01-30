namespace Business.Request.CorporateCustomer
{
    public class DeleteCorporateCustomerRequest
    {
        public int Id { get; set; }

        public DeleteCorporateCustomerRequest(int ıd)
        {
            Id = ıd;
        }
    }
}