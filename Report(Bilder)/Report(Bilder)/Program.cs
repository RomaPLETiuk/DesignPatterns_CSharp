
using Report_Bilder_;

List<Employee> employees = new()
  {
    new Employee { Name = "Ivan", Salary = 100 },
    new Employee { Name = "Boris", Salary = 50 },
    new Employee { Name = "Roman", Salary = 150 },
    new Employee { Name = "Petro", Salary = 240 },
    new Employee { Name = "Fedor", Salary = 200 }


  };

var builder = new EmployeeReportBilder(employees);
var director = new EmployeeReportDirector(builder);
director.Build();
var report = builder.GetReport();
Console.WriteLine(report);
Console.ReadKey();