using Business.Dtos.Brand;

namespace Business;

public class GetTransmissionListResponse
{
    public ICollection<BrandListItemDto> Items { get; set; }

    public GetTransmissionListResponse()
    {
        Items = Array.Empty<BrandListItemDto>();
    }

    public GetTransmissionListResponse(ICollection<BrandListItemDto> items)
    {
        Items = items;
    }
}