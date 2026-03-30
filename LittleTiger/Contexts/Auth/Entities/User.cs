namespace LittleTiger.Contexts.Auth.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User(string email, string password) 
        {
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.Password = password;
        }
        
        public string Login()
        {
            // desenvolvimento no método de login

            return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWUsImlhdCI6MTUxNjIzOTAyMn0.KMUFsIDTnFmyG3nMiGM6H9FNFUROf3wh7SmqJp-QV30";
        }

        public void Logout(string jwt)
        {
            // logica para logout
        }
    }
}
