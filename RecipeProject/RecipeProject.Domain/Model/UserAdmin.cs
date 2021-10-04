namespace RecipeProject.Domain.Model
{
    public class UserAdmin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private UserAdmin()
        {

        }
        public UserAdmin(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }
}
