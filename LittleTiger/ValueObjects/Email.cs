namespace LittleTiger.ValueObjects
{
    public class Email
    {
        public string Value { get; private set; }

        public Email(string newEmail)
        {
            if (string.IsNullOrEmpty(newEmail) || !newEmail.Contains("@"))
            {
                throw new Exception("Email Inválido");
            }

            this.Value = newEmail;
        }
    }
}
