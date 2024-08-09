# DummiesEmployees

## Overview

This project is an MVC application that demonstrates good design practices and coding principles. It includes a data access layer for consuming APIs, a business logic layer for salary calculations, and a Web API controller for handling requests. The frontend view is implemented using Angular and styled with Bootstrap.

## Requirements

- **Visual Studio 2017 or higher** (Visual Studio Community is recommended)
- **.NET Core 8** or higher
- **Node.js** and **npm** (for Angular setup)
- **Git** (for cloning the repository)

## Project Structure

1. **Data Access Layer**: Handles API communication.
2. **Business Logic Layer**: Calculates annual salary.
3. **Web API Controller**: Provides endpoints for employees and employee data.
4. **Angular Frontend**: Displays employee information and search functionality.
5. **Unit Tests**: Tests business logic methods.

## Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/your-repository.git
cd your-repository
```

### 2. Set Up the .NET Core Backend

1. **Open the Solution**: Launch Visual Studio and open the solution file (`.sln`).

2. **Restore NuGet Packages**: 
   ```bash
   dotnet restore
   ```

3. **Build the Project**: 
   ```bash
   dotnet build
   ```

4. **Run the Application**: 
   ```bash
   dotnet run
   ```

   The application will be accessible at `http://localhost:5000` (or another port if configured).

### 3. Set Up the Angular Frontend

1. **Navigate to the Angular Project Directory**: 
   ```bash
   cd YourAngularProject
   ```

2. **Install Dependencies**: 
   ```bash
   npm install
   ```

3. **Run the Angular Application**: 
   ```bash
   ng serve
   ```

   The Angular application will be accessible at `http://localhost:4200`.

## Usage

1. **Open the Web Application**: Access the application through `http://localhost:4200`.

2. **Search for Employees**:
   - Enter an employee ID in the textbox and click the search button to retrieve specific employee data.
   - Leave the textbox empty and click the search button to retrieve the complete list of employees.

3. **View Employee Information**: The results will be displayed in a table, including the calculated annual salary.

## Unit Testing

To run the unit tests for the business logic layer:

1. **Navigate to the Test Project Directory**: 
   ```bash
   cd YourTestProject
   ```

2. **Run the Tests**: 
   ```bash
   dotnet test
   ```

## Troubleshooting

- **429 Status Code**: If you encounter a 429 status code (Too Many Requests), it indicates that the API rate limit has been exceeded. Try again later.
- **Invalid ID Error**: Ensure that the employee ID is a positive integer.

## Contributing

Feel free to submit issues or pull requests. Ensure that your code adheres to the project’s coding standards and passes all tests.

## License

This project is licensed under the GNU General Public License version 3 (GPL-3.0). You may obtain a copy of the License at [https://www.gnu.org/licenses/gpl-3.0.en.html](https://www.gnu.org/licenses/gpl-3.0.en.html).

---

This version omits the migrations step since it's not applicable to your project.
