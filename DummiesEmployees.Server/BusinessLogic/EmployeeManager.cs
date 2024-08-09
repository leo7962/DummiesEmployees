namespace DummiesEmployees.Server.BusinessLogic
{
    public class EmployeeManager
    {
        public decimal CalculateAnnualSalary(decimal monthlySalary)
        {
            return monthlySalary * 12;
        }
    }
}
