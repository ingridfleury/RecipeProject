using RecipeProject.Domain.Model;
using System;
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

        [Fact]
        public void Construct_with_Name_MinLenght_Should_Thwow()
        {
            // Arrange
            int minLengh = 2;

            string name = "a";
            string preparation = "a";
            // Act                  
            // Asset
            Assert.Throws<ArgumentException>(() => _sut = new Recipe(name, preparation));
        }
        [Fact]
        public void Construct_with_Name_MaxLenght_Should()
        {
            // Arrange
            int maxLengh = 30;

            string name = "ooooooooooooooooooooooooooooooo";
            string preparation = "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo" +
                "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo" +
                "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo" +
                "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo" +
                "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo" +
                "oooooooooooooooooooo";
            // Act                  
            // Asset
            Assert.Throws<ArgumentException>(() => _sut = new Recipe(name, preparation));
        }

        [Fact]
        public void Construct_with_Name_Empty_Should_Thwow()
        {
            // Arrange
            string name = "";
            string preparation = "Pegue uma panela";
            // Act                  
            // Asset
            Assert.Throws<ArgumentNullException>(() => _sut = new Recipe(name, preparation));
        }

        [Fact]
        public void Construct_with_CorrectValues_Should()
        {
            // Arrange

            string name ="Carbonara";
            string preparation = "Pegue uma panela";

            // Act
            _sut = new Recipe(name, preparation);
            // Asset
            Assert.IsType<Recipe>(_sut);
        }
    }
}
