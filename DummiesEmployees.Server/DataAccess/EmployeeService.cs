namespace DummiesEmployees.Server.DataAccess
{
    public class EmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetEmployeesAsync()
        {
            var response = await httpClient.GetStringAsync("http://dummy.restapiexample.com/api/v1/employees");
            return response;
        }

        public async Task<string> GetEmployeeByIdAsync(int id)
        {
            var response = await httpClient.GetStringAsync($"http://dummy.restapiexample.com/api/v1/employee/{id}");
            return response;
        }
    }
}
