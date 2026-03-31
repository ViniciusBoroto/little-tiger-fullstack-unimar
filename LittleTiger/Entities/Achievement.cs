namespace LittleTiger.Entities
{
    public class Achievement : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public int? RequiredWonAmount { get; private set; }
        public int? RequiredPlacedBets { get; private set; }

        public Achievement(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public Achievement(string name, string description, int? requiredWonAmount, int? requiredPlacedBets) : this(name, description) 
        {
            this.RequiredWonAmount = requiredWonAmount;
            this.RequiredPlacedBets = requiredPlacedBets;
        }
        public bool ProfileHasAchievement(Profile profile)
        {
            if (this.RequiredWonAmount.HasValue && profile.WonAmount < this.RequiredWonAmount.Value)
                return false;

            if (this.RequiredPlacedBets.HasValue && profile.PlacedBets < this.RequiredPlacedBets.Value)
                return false;

            return true;
        }
        
    }
}
