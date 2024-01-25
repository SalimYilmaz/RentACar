namespace Business.Requests.Model;

public class GetModelByIdRequest
{
    public int Id { get; set; }

    public GetModelByIdRequest(int ıd)
    {
        Id = ıd;
    }
}