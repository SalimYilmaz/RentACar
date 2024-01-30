namespace Business.Requests.Model
{
    public class GetModelListRequestByBrand
    {
        public int BrandId { get; set; }

        public GetModelListRequestByBrand(int brandId)
        {
            BrandId = brandId;
        }
    }
}