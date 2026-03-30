namespace LittleTiger.ValueObjects
{
    public class Amount
    {
        public decimal Value { get; set; }

        public Amount(decimal value)
        {
            if (value <= 0)
            {
                throw new Exception("Valor invalido");
            }

            this.Value = value; 
        }
    }
}
