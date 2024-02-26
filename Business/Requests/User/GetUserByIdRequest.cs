namespace Business.Requests.User
{
    public class GetUserByIdRequest
    {
        public int Id { get; set; }

        public GetUserByIdRequest(int ıd)
        {
            Id = ıd;
        }
    }
}