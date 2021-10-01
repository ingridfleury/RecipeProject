namespace RecipeProject.Domain.Model
{
    public class UserRegister
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        private UserRegister()
        {

        }
        public UserRegister(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }
}
