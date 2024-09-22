using System;

class Employee
{
    // Fields for employee details
    public string Name { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }

    // Method to display employee details
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Employee Email: {Email}");
        Console.WriteLine($"Employee Salary: {Salary:C}");
    }
}

class Program
{
    /*static void Main(string[] args)
    {
        // Create an object for the Employee class
        Employee employee = new Employee();

        // Get employee details from user input
        Console.Write("Enter employee name: ");
        employee.Name = Console.ReadLine();

        Console.Write("Enter employee email: ");
        employee.Email = Console.ReadLine();

        Console.Write("Enter employee salary: ");
        employee.Salary = double.Parse(Console.ReadLine());

        // Display the employee information
        Console.WriteLine("\nEmployee Details:");
        employee.DisplayEmployeeInfo();

        // Wait for user input before closing the program
        Console.ReadKey();
    }*/
}
