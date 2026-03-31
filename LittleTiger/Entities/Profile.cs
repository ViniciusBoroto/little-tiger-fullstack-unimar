namespace LittleTiger.Entities
{
    public class Profile : EntityBase
    {
        public List<Achievement> Achivements { get; private set; }
        public decimal WonAmount { get; private set; }
        public int PlacedBets { get; private set; }

        public Profile()
        {
            
        }
    }
   
}
