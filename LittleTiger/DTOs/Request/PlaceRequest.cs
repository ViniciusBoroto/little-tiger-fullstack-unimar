namespace LittleTiger.DTOs.Request
{
    public class PlaceRequest
    {
        public Guid UserId { get; set; }
        public Guid BetId { get; set; }
        public decimal Amount { get; set; }
        public string Team { get; set; }
    }
}
