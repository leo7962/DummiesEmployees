import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/employee.service';
import { catchError, of } from 'rxjs';

@Component({
  selector: 'app-employee-search',
  templateUrl: './employee-search.component.html',
  styleUrl: './employee-search.component.css'
})
export class EmployeeSearchComponent implements OnInit {
  employees: any[] = [];
  employeeId: number | null = null;
  errorMessage: string | null = null;

  constructor(private employeeService: EmployeeService) { }

  ngOnInit(): void {
    this.loadEmployees();
  }

  loadEmployees(): void {
    this.employeeService.getEmployees().pipe(
      catchError(error => {
        if (error.status === 429) {
          this.errorMessage = 'Too Many Requests. Please try again later.';
        } else {
          this.errorMessage = 'An error occurred while fetching employee data.';
        }
        return of([]);
      })
    ).subscribe(data => {
      this.employees = data.data || [];
    });
  }

  searchEmployee(): void {
    if (this.employeeId) {
      this.employeeService.getEmployeeById(this.employeeId).pipe(
        catchError(error => {
          if (error.status === 429) {
            this.errorMessage = 'Too Many Requests. Please try again later.';
          } else {
            this.errorMessage = 'Too Many Requests. Please try again later.';
          }
          return of(null);
        })
      ).subscribe(data => {
        this.employees = data ? [data.data] : [];
      });
    } else {
      this.loadEmployees();
    }
  }
}
