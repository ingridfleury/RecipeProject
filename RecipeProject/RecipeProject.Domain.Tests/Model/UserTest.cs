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
            byte[] PasswordHash = null;  // *: qual tipo da variável devo utilizar para o teste?
            byte[] PasswordSalt = null;

            //Act
            _sut = new User();

            //Assert

            Assert.Equal(PasswordSalt, PasswordHash);
            // *: O retorno deste assert será boolean?



        }

    }
}
