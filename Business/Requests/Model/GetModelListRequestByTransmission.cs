namespace Business.Requests.Model
{
    public class GetModelListRequestByTransmission
    {
        public int TransmissionId { get; set; }

        public GetModelListRequestByTransmission(int transmissionId)
        {
            TransmissionId = transmissionId;
        }
    }
}