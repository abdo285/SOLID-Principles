public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
    
    public decimal CalculateYearlySalary()
        {
        return Salary * 12;
        }

}

class EmployeeReportGenerator
{
    public decimal GenerateReport(Employee employee, string reportType)
    {
        // Code to generate report based on reportType
    }
}

class EmployeeNotificationService
{
    public void SendNotification(Employee employee, string recipient, string message)
    {
        // Code to send email notification
    }
}