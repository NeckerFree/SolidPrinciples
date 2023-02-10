//SOLID is a mnemonic acronym and each of the letters in it stands for:

//S – Single Responsibility Principle
//O – Open/Closed Principle
//L – Liskov Substitution Principle
//I – Interface Segregation Principle
//D – Dependency Inversion Principle
using SP.Validation.Models;
using SP.Validation.Principles._2_OCP;
using SP.Validation.Principles._3_LSP;
using SP.Validation.Principles._4_ISP.Implementation;
using SP.Validation.Principles._5_DIP;
using SP.Validation.Principles._5_DIP.Implementation;
using SP.Validation.Principles.SRP;
using SP.Validation.Principles.SRP.Implementation;
using static SP.Validation.Models.Enumerations;


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

#region 03 LSP
//The Liskov Substitution Principle (LSP) states that child class objects 
//should be able to replace parent class objects without compromising 
//application integrity. What this means essentially, is that we should 
//put an effort to create such derived class objects which can replace 
//objects of the base class without modifying its behavior. If we don’t, 
//our application might end up being broken.


//#region Initial
//var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//SumCalculator_Initial sum = new SumCalculator_Initial(numbers);
//Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
//Console.WriteLine();
//EvenNumbersSumCalculator_Initial evenSum = new EvenNumbersSumCalculator_Initial(numbers);
//Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

//SumCalculator_Initial evenSumR = new EvenNumbersSumCalculator_Initial(numbers);
//Console.WriteLine($"The sum of all the even numbers: {evenSumR.Calculate()}"); 
//#endregion
#region LSP Applied
//var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//Calculator_LSP sum = new SumCalculator_LSP(numbers);
//Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
//Console.WriteLine();
//EvenNumbersSumCalculator_LSP evenSum = new EvenNumbersSumCalculator_LSP(numbers);
//Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

//SumCalculator_LSP evenSumR = new EvenNumbersSumCalculator_LSP(numbers);
//Console.WriteLine($"The sum of all the even numbers: {evenSumR.Calculate()}");
#endregion
#endregion

#region 04 ISP
//The Interface Segregation Principle states that no client should be forced 
//to depend on methods it does not use. 
//The ISP states that we should reduce code objects down to the smallest required 
//implementation thus creating interfaces with only required declarations. 
//As a result, an interface that has a lot of different declarations should be 
//split up into smaller interfaces.
#region Initial
//MultiFunctionalCar_Initial mfIni=new MultiFunctionalCar_Initial();
//mfIni.Drive();
//mfIni.Fly();

//Car_Initial carIni= new Car_Initial();
//carIni.Drive();
//carIni.Fly();

//Airplane_Initial airplaneIni= new Airplane_Initial();
//airplaneIni.Drive();
//airplaneIni.Fly();
#endregion
#region ISP Applied
//MultifunctionalCar_ISP mfIni = new MultifunctionalCar_ISP();
//mfIni.Drive();
//mfIni.Fly();

//Car_ISP carIni = new Car_ISP();
//carIni.Drive();

//Airplane_ISP airplaneIni = new Airplane_ISP();
//airplaneIni.Fly();
#endregion

#endregion

#region 05 DIP
//we should create the higher-level modules with its complex logic in such a way
//to be reusable and unaffected by any change from the lower-level modules in our application.
//To achieve this kind of behavior in our apps, we introduce abstraction which decouples
//higher from lower-level modules.

//Having this idea in mind the Dependency Inversion Principle states that

//High-level modules should not depend on low-level modules, both should depend on abstractions.
//Abstractions should not depend on details. Details should depend on abstractions.
#region Initial
//EmployeeManager_Initial employeeManager = new EmployeeManager_Initial();
//employeeManager.AddEmployee(new Employee
//{
//     Gender= Enumerations.Gender.Male,
//      Name="Elio Nel",
//       Position= Enumerations.Position.Manager
//});
//employeeManager.AddEmployee(new Employee
//{
//    Gender = Enumerations.Gender.Female,
//    Name = "Adriana",
//    Position = Enumerations.Position.Manager
//});
//employeeManager.AddEmployee(new Employee
//{
//    Gender = Enumerations.Gender.Female,
//    Name = "Catalina",
//    Position = Enumerations.Position.Manager
//});
//EmployeeStatistics_Initial employeeStatistics = new EmployeeStatistics_Initial(employeeManager);
//Console.WriteLine($"Count Females Managers: {employeeStatistics.CountFemaleManagers()}");
#endregion
#region DIP Applied
//var empManager = new EmployeeManager_DIP();
//empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
//empManager.AddEmployee(new Employee { Name = "Helena", Gender = Gender.Female, Position = Position.Manager });
//empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
//var stats = new EmployeeStatistics_DIP(empManager);
//Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
var empManager = new EmployeeManager_DIC();
empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
empManager.AddEmployee(new Employee { Name = "Helena", Gender = Gender.Female, Position = Position.Manager });
empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
var stats = new EmployeeStatistics_DIP(empManager);
Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
#endregion
#endregion