namespace Business.Requests.Model;

public class GetModelListRequest
{
    public int? FilterByBrandId { get; set; }
    public int? FilterByFuelId { get; set; }
    public int? FilterByTransmissionId { get; set; }

    public GetModelListRequest(int? filterByBrandId, int? filterByFuelId, int? filterByTransmissionId)
    {
        FilterByBrandId = filterByBrandId;
        FilterByFuelId = filterByFuelId;
        FilterByTransmissionId = filterByTransmissionId;
    }
}