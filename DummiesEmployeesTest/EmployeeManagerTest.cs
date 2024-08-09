using DummiesEmployees.Server.BusinessLogic;

namespace DummiesEmployeesTest
{
    public class EmployeeManagerTest
    {
        [Fact]
        public void CalculateAnnualSalary_ShouldReturnCorrectValue()
        {
            // Arrange
            var manager = new EmployeeManager();
            var monthlySalary = 5000m;

            // Act
            var annualSalary = manager.CalculateAnnualSalary(monthlySalary);

            // Assert
            Assert.Equal(60000m, annualSalary);
        }
    }
}