namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] HashPassword { get; set; }
        public byte[] SaltPasword { get; set; }

    }
}