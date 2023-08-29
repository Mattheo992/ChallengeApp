using ChallengeApp;

var employee = new Employee ("Mateusz", "Stępniak");
employee.AddGrade("Mateusz");
employee.AddGrade("6000");
employee.AddGrade(6);
employee.AddGrade(2.2);
employee.AddGrade(31);
var statictics = employee.GetStatistics();
