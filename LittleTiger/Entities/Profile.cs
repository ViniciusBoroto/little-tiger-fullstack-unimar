using LittleTiger.ValueObjects;

namespace LittleTiger.Entities
{
    public class Profile : EntityBase
    {
        public List<Achievement> Achivements { get; private set; }
        public Amount WonAmount { get; private set; } //quantidade de lucro 
        public int PlacedBets { get; private set; }

        public Profile()
        {

        }

        //TODO: métodos para aumentar  contador (placedbets) e o lucro (WonAmount)

        public void IncreaseAmount(Amount wonAmount)
        {
            this.WonAmount += wonAmount;
        }
        public void InceasePlacedBets()
        {
            this.PlacedBets += 1;
        }
    }

}
