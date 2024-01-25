namespace Business.Responses.Model;

public class GetModelListResponse
{
    public ICollection<ModelListItemDto> Items { get; set; }

    public GetModelListResponse(ICollection<ModelListItemDto> ıtems)
    {
        Items = ıtems;
    }
}