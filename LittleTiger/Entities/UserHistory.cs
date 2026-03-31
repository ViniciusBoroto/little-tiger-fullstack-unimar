namespace LittleTiger.Entities
{
    public class UserHistory : EntityBase
    {
        public decimal WonAmount { get; private set; }
        public int PlacedBets { get; private set; }
    }
}
