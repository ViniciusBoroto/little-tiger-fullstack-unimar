using LittleTiger.ValueObjects;

namespace LittleTiger.Entities
{
    public class Player : EntityBase
    {
        public Email Email { get; private set; }
        public Nickname Nickname { get; private set; }
        public Amount Amount { get; private set; }

        public void UpdateNickname(Nickname newNickname)
        {
            this.Nickname = newNickname;
        }

        public void UpdateEmail(Email newEmail)
        {
            this.Email = newEmail;
        }
    
        public void Discount(Amount amount)
        {
            if (amount.Value > this.Amount.Value) 
            {
                throw new Exception("Saldo insuficiente");
            }

            this.Amount.Value -= amount.Value;
        }
    }
}
