using ChallengeApp;

var employee = new Employee ("Mateusz", "Stępniak");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statictics = employee.GetStatistics ();   
Console.WriteLine($"Avarage: {statictics.Avarage:N2}");
Console.WriteLine($"Min: {statictics.Min}");
Console.WriteLine($"Max {statictics.Max}");