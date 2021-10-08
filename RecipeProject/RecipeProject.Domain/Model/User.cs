using System;

namespace RecipeProject.Domain.Model
{
    public class User 
    {
        private string _Name;

        private string _Email;

        public int UserId { get; set; }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (ValidateName(value))
                {
                    _Name = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (ValidateEmail(value))
                {
                    _Email = value;
                }

            }
        }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
       

        private bool ValidateName(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name can't be empty or null");
            }

            if (name.Length <= 2)
            {
                throw new ArgumentException("name can't be less then 2");
            }

            if(name.Length >= 20)
            {
                throw new ArgumentException("name can't be more then 20");

            }

            if (int.TryParse(name, out int parsedName))
            {
                throw new ArgumentException("name can't be a number");

            }

            return true;
        }

        private bool ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("E-mail can't be empty or null");
            }

            if (email.Length < 5)
            {
                throw new ArgumentException("E-mail can't be less then 5");
            }

            return true;
        }
    }
}
