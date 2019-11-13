using WorkingWithVisualStudio.Models;
using Xunit;

namespace WorkingWithVisualStudio.Tests
{
    public class ProductTests // Имя класса то, что подвергается тестированию
    {
        /// <summary>
        /// arrange/act/assert - /A/A/A
        /// </summary>

        [Fact]
        public void CanChangeProductName() // Имя метода описывает то, что делает тест
        {
            // Организация
            var p = new Product {Name = "Test", Price = 100M};
            // Действие
            p.Name = "New Name";
            // Утвеждение
            Assert.Equal("New Name", p.Name);
        }
        [Fact]
        public void CanChangeProductPrice()
        {
            // Организация
            var p = new Product { Name = "Test", Price = 100M };
            // Действие
            p.Price = 200M;
            // Утверждение
            Assert.Equal(100M, p.Price);

        }
    }
}
