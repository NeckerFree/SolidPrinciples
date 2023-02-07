//SOLID is a mnemonic acronym and each of the letters in it stands for:

//S – Single Responsibility Principle
//O – Open/Closed Principle
//L – Liskov Substitution Principle
//I – Interface Segregation Principle
//D – Dependency Inversion Principle
using SP.Validation.Models;
using SP.Validation.Principles._2_OCP;
using SP.Validation.Principles.SRP;
using SP.Validation.Principles.SRP.Implementation;


#region 01 SRP
//The Single Responsibility Principle states that our classes should have only one reason to change 
//or in other words, it should have only one responsibility.

#region Initial
//WorkReport_Initial wordReport = new WorkReport_Initial();
//wordReport.AddEntry(new WorkReportEntry
//{
//    ProjectCode = "1",
//    ProjectName = "Project 1",
//    SpentHours = 10,
//});
//wordReport.AddEntry(new WorkReportEntry
//{
//    ProjectCode = "2",
//    ProjectName = "Project 2",
//    SpentHours = 15,
//});

//Console.WriteLine(wordReport.ToString());
//wordReport.SaveToFile(@"C:\Temp", "WorkReport.txt");
#endregion

#region SRP Applied
//WorkReport_SRP wordReport = new WorkReport_SRP();
//wordReport.AddEntry(new WorkReportEntry
//{
//    ProjectCode = "1",
//    ProjectName = "Project 1",
//    SpentHours = 10,
//});
//wordReport.AddEntry(new WorkReportEntry
//{
//    ProjectCode = "2",
//    ProjectName = "Project 2",
//    SpentHours = 15,
//});
//Console.WriteLine(wordReport.ToString());
//FileSaver fileSaver = new FileSaver();
//fileSaver.SaveToFile(@"C:\Temp", "WorkReport.txt", wordReport);

//Scheduler_SRP scheduler = new Scheduler_SRP();
//scheduler.AddEntry(new ScheduleTask
//{
//    TaskId = 3,
//    Content = "Content task 3",
//    ExecutedOn = DateTime.Now.AddDays(1)
//});
//scheduler.AddEntry(new ScheduleTask
//{
//    TaskId = 4,
//    Content = "Content task 4",
//    ExecutedOn = DateTime.Now.AddDays(2)
//});

//Console.WriteLine(scheduler.ToString());
//fileSaver.SaveToFile(@"C:\Temp", "Scheduler.txt", scheduler);
#endregion

#endregion

#region 02 OCP
//The Open Closed Principle (OCP) is the SOLID principle 
//which states that the software entities (classes or methods) 
//should be open for extension but closed for modification.
//we should strive to write a code that doesn’t require modification
//every time a customer changes its request.
#region Initial
//List<DeveloperReport> devReports = new List<DeveloperReport> {
//        new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 },
//        new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
//        new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 }
//    };

//var calculator = new SalaryCalculator_Initial(devReports);
//Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
#endregion
//now our boss comes to our office and says that we need a different calculation 
//    for the senior and junior developers. The senior developers should have 
//    a bonus of 20% on a salary.

#region OCP Applied
//var devCalculations = new List<BaseSalaryCalculator>
//        {
//            new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
//            new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
//            new SeniorDevSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
//        };

//var calculator = new SalaryCalculator_OCP(devCalculations);
//Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");

#endregion
#endregion