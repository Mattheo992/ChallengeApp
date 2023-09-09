using ChallengeApp;

Console.WriteLine("Witamy w Programie Ocena Pracownika v1 do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("Po dodaniu ocen naciśnij q aby przejść do podsumowania");
Console.WriteLine();


var employee = new EmployeeInMemory("Mateusz", "Stępniak");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}
employee.AddGrade(0.6f);
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }

    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statictics = employee.GetStatistics();
Console.WriteLine($"AVG: {statictics.Average}");
Console.WriteLine($"AVG: {statictics.AverageLetter}");
Console.WriteLine($"MIN: {statictics.Min}");
Console.WriteLine($"MAX: {statictics.Max}");









