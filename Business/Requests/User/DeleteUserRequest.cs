namespace Business.Requests.User
{
    public class DeleteUserRequest
    {
        public DeleteUserRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }

    }
}