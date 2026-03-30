namespace LittleTiger.ValueObjects
{
    public class Nickname
    {
        public string Value { get; private set; }
        public Nickname(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Nickname Inválido");
            }

            if (value.Length < 3)
            {
                throw new Exception("Nickname com tamanho inválido");
            }

            this.Value = value;
        }
    }
}
