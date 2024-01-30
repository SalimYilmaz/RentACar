namespace Business.Responses.IndividualCustomer
{
    public class DeleteIndividualCustomerResponse
    {
        public DeleteIndividualCustomerResponse(int ıd, string firstName, string lastName, string nationalIdentity, DateTime deletedAt, int customerId)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            DeletedAt = deletedAt;
            CustomerId = customerId;
        }
        public DeleteIndividualCustomerResponse()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime DeletedAt { get; set; }
        public int CustomerId { get; set; }

    }
}