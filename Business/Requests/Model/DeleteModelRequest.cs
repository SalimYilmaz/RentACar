namespace Business.Requests.Model;

public class DeleteModelRequest
{
    public int Id { get; set; }


    public DeleteModelRequest(int ıd)
    {
        Id = ıd;
    }
}