using CITestExampleApp;
using Xunit;

namespace CITestExampleAppTest
{
    public class CalculatorTests
    {
        // Fact этот атрибут указывает, что метод является тестовым методом,
        // который должен быть выполнен при запуске тестов.
        // В данном случае, метод Add_TwoNumbers_ReturnsSum будет выполняться как тест,
        // и его результат будет проверяться с помощью Assert.Equal.
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            
            Console.WriteLine("Working only on GitHub workflow (Github Action)");
            // Arrange
            var calculator = new Calculator();

            Console.WriteLine("Running Add_TwoNumbers_ReturnsSum test...");
            // Act
            var result = calculator.Add(2, 3);

            Console.WriteLine("This test verifies that the Add method correctly sums two integers.");
            // Assert
            Assert.Equal(5, result);
        }
    }
}
