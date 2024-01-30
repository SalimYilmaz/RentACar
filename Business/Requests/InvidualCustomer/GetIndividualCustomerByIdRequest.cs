namespace Business.Abstract
{
    public class GetIndividualCustomerByIdRequest
    {
        public int Id { get; set; }

        public GetIndividualCustomerByIdRequest(int ıd)
        {
            Id = ıd;
        }
    }
}