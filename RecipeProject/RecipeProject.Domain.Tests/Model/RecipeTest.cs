using RecipeProject.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RecipeProject.Domain.Tests.Model
{
    public class RecipeTest
    {
        private Recipe _sut;

        [Fact]
        public void Construct_With_Name_Null_Should_Throw()
        {
            // Arrange
            string name = null;
            string preparationMethod = "preparation";

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => _sut = new Recipe(name, preparationMethod));

        }

    }
}
