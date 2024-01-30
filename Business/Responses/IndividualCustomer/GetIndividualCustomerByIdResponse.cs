namespace Business.Responses.IndividualCustomer
{
    public class GetIndividualCustomerByIdResponse
    {
        public GetIndividualCustomerByIdResponse(int ıd, string firstName, string lastName, string nationalIDentity, int customerId)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIDentity = nationalIDentity;
            CustomerId = customerId;
        }
        public GetIndividualCustomerByIdResponse()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIDentity { get; set; }
        public int CustomerId { get; set; }
    }
}