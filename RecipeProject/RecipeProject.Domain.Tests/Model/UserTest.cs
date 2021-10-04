using RecipeProject.Domain.Model;
using Xunit;

namespace RecipeProject.Domain.Tests.Model
{
    public class UserTest
    {
        private User _sut;

        [Fact]
        public void Password_Validation_Equal()
        {
            //Arrange
            string PasswordHash = "qualquercoisa";
            string PasswordSalt = "014058BE15231033838DA0D8C5EBDC22";

            byte[] passwordHash2 = System.Text.Encoding.ASCII.GetBytes(PasswordHash);
            byte[] passwordSalt2 = System.Text.Encoding.ASCII.GetBytes(PasswordSalt);

            //Act
            _sut = new User();

            //Assert

            Assert.Equal(PasswordSalt, PasswordHash);
        }

        [Fact]
        public void Password_Validation_Not_Equal()
        {
            //Arrange
            string PasswordHash = "qualquer";
            string PasswordSalt = "014058BE15231033838DA0D8C5EBDC22";

            byte[] passwordHash2 = System.Text.Encoding.ASCII.GetBytes(PasswordHash);
            byte[] passwordSalt2 = System.Text.Encoding.ASCII.GetBytes(PasswordSalt);

            //Act
            _sut = new User();

            //Assert

            Assert.Equal(PasswordSalt, PasswordHash);
        }

        [Fact]
        public void Contruct_With_Name_Null_Shoud_Throw()
        {
            //Arrange


            //Act


            //Assert
        }
    }
}
