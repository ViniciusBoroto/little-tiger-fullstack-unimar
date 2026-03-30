using LittleTiger.ValueObjects;

namespace LittleTiger.Entities
{
    public class UserBet : EntityBase
    {
        public Guid UserId { get; private set; }
        public Guid BetId { get; private set; }
        public Team Team {  get; private set; }
        public Amount Amount { get; private set; }

        public UserBet(Guid userId, Guid betId, Amount amount, string team) 
        {
            this.UserId = userId;
            this.BetId = betId;
            this.Team = team;
            this.Amount = amount;
        }
    }
}
