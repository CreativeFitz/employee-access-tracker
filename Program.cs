using System;
using System.Collections.Generic;

List<Employee> employees = new List<Employee>();

employees.Add(new Employee (1, "John", "Doe", "Network Engineer", "IT", "Admin"));
employees.Add(new Employee (2, "Mami", "Ralek", "Gray Hat", "IT", "Admin"));

foreach (var emp in employees)
{
    emp.Display();
}
