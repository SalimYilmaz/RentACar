using Business.Dtos.Brand;
using Entities.Concrete;

namespace Business;

public class GetFuelListResponse
{
    public ICollection<BrandListItemDto> Items { get; set; }
    public ICollection<Fuel> Fuels { get; set; }

    public GetFuelListResponse()
    {
        Items = Array.Empty<BrandListItemDto>();
    }

    public GetFuelListResponse(ICollection<BrandListItemDto> items)
    {
        Items = items;
    }
}