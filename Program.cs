using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

List<Employee> employees = new List<Employee>();



employees.Add(new Employee (1, "John", "Doe", "Network Engineer", "IT", "Admin"));
employees.Add(new Employee (2, "Mami", "Ralek", "Gray Hat", "IT", "Admin"));




int nextId = 3;





string userInputVerification;

string ConfirmingUserInput (string prompt){

    bool userConfirmation = false;
    string result = "";  

    while (!userConfirmation)
    {
    Console.WriteLine(prompt);
        userInputVerification = Console.ReadLine();
        Console.WriteLine($"You have entered {userInputVerification}, is that correct? y/n");
    
        string userResponse = Console.ReadLine();
        if (userResponse.ToLower() == "y")
        {
            result = userInputVerification;
            userConfirmation = true;

        }
        else 
        {
            // Returning user to input prompt again.
        }
        
    } 
    return result;
}

// Selection menu
bool running = true;
while (running)
{
    Console.WriteLine("Please select an option from the menu");
    Console.WriteLine("1: Create your employee profile");
    Console.WriteLine("2: Print all current employees");
    Console.WriteLine("3: End Program");

    string userChoice = Console.ReadLine();
    
    switch (userChoice)
    {
    case "1":
    AddEmployee(employees, ref nextId);
    break;
    
    case "2":
    PrintEmployees(employees);
    break;

    case "3":
    running = false;
    break;

    default:
    Console.WriteLine("Incorrect input, please select from one of the options above.");
    break;


    }
}


// Displays all created employees' details 

void PrintEmployees(List<Employee> employees){
    foreach (var emp in employees)
{
    emp.Display();
}
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("Press any key to continue");
    Console.ReadLine();
};


// Guides user through the process of creating their employee details.

void AddEmployee (List<Employee> employees, ref int nextId)
{
    string employeeFirstName = ConfirmingUserInput("Please enter your first name.");
    string employeeLastName = ConfirmingUserInput("Please enter your last name.");
    string employeePosition = ConfirmingUserInput("Please enter your position.");
    string employeeDepartment = ConfirmingUserInput("Please enter your department.");
    string employeeAccessLevel = "Personal"; 
    

    employees.Add(new Employee(nextId++, employeeFirstName, employeeLastName, employeePosition, employeeDepartment, employeeAccessLevel));
     Console.WriteLine($"Thank you, {employeeFirstName} {employeeLastName}, your role is set to {employeePosition} under the {employeeDepartment} department. Your current user access is set to {employeeAccessLevel}. Contact HR if any of this is incorrect!");
}
