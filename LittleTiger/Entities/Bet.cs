using LittleTiger.ValueObjects;

namespace LittleTiger.Entities
{
    public class Bet : EntityBase
    {
        public Team ATeam { get; private set; }
        public float OddATime { get; private set; }
        public Team BTeam { get; private set; }
        public float OddBTime { get; private set; }
        public float OddHouse { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime FinishDate { get; private set; }
        public decimal TotalCollected { get; private set; }
        public List<UserBet> _bettors { get; private set; }
        public IReadOnlyCollection<UserBet> Bettors => _bettors.AsReadOnly();

        public void Create(Team teamA, Team teamB)
        {
            this.Id = new Guid();
            this.ATeam = teamA;
            this.BTeam = teamB;
        }

        public void Place(Guid userId, Amount amount, Team team)
        {
            UserBet userBet = new UserBet(userId, this.Id, amount, team);
            this._bettors.Add(userBet);
        }
    }
}
