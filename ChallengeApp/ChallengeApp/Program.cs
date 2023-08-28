using ChallengeApp;

var employee = new Employee ("Mateusz", "Stępniak");
employee.AddGrade("Mateusz");
employee.AddGrade("6000");
employee.AddGrade(6);
employee.AddGrade(2.2);
employee.AddGrade(31);
var statictics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStaticticsWithFor();
var statistics3 = employee.GetStaticticsDoWhile();
var statistics4 = employee.GetStaticticsWhile();
Console.WriteLine($"Get Statistics With For Each: Avarage - {statistics1.Avarage:N2} , Min - {statistics1.Min} , Max - {statistics1.Max}");
Console.WriteLine($"Get Statistics With For: Avarage - {statistics2.Avarage:N2} , Min - {statistics2.Min} , Max - {statistics2.Max}");
Console.WriteLine($"Get Statistics With Do While: Avarage - {statistics3.Avarage:N2} , Min - {statistics3.Min} , Max - {statistics3.Max}");
Console.WriteLine($"Get Statistics With While: Avarage - {statistics4.Avarage:N2} , Min - {statistics4.Min} , Max - {statistics4.Max}");