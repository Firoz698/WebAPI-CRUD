namespace PracticeAspDotNet.Model
{
    public class User
    {
        public User()
        {
            Id = 0;
            Name = "";
            Email = "";
            Address = "";
            Password = "";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        
    }




}
