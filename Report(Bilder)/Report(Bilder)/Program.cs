
using Report_Builder;

var employees = new List<Employee>
{
    new("Ivan", 100),
    new("Boris", 50),
    new("Roman", 150),
    new("Petro", 240),
    new("Fedor", 200)
};

IEmployeeReportBuilder builder = new EmployeeReportBuilder(employees);
var director = new EmployeeReportDirector(builder);

EmployeeReport report = director.BuildFullReport();

Console.WriteLine(report);
Console.ReadKey();
