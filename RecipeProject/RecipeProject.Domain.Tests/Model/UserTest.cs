using RecipeProject.Domain.Model;
using Xunit;

namespace RecipeProject.Domain.Tests.Model
{
    public class UserTest
    {
        private User _sut;

        [Fact]
        public void PasswordSalt_Equal_to_PasswordHash_Should_Throw() 
            // *: existe uma convenção para a definição do nome do método de teste?
        {
            //Arrange
            string PasswordHash = "qualquercoisa";  // *: qual tipo da variável devo utilizar para o teste?
            string PasswordSalt = "014058BE15231033838DA0D8C5EBDC22";

            byte[] passwordHash2 = System.Text.Encoding.ASCII.GetBytes(PasswordHash);
            byte[] passwordSalt2 = System.Text.Encoding.ASCII.GetBytes(PasswordSalt);
            //Act
            _sut = new User();

            //Assert

            Assert.Equal(PasswordSalt, PasswordHash);
            // *: O retorno deste assert será boolean?



        }

        //public void PasswordValidationEqual()
        //public void PasswordValidationNotEqual()

    }
}
