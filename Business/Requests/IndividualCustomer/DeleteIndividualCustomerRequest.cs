namespace Business.Abstract
{
    public class DeleteIndividualCustomerRequest
    {
        public int Id { get; set; }

        public DeleteIndividualCustomerRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
