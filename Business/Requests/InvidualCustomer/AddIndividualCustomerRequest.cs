namespace Business.Abstract
{
    public class AddIndividualCustomerRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public int CustomerId { get; set; }

        public AddIndividualCustomerRequest(string firstName, string lastName, string nationalIdentity, int customerId)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            CustomerId = customerId;
        }
    }
}