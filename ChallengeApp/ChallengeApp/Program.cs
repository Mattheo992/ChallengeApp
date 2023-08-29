using ChallengeApp;


Console.WriteLine("Witamy w Programie Ocena Pracownika v1 do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();


var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statictics = employee.GetStatistics();
Console.WriteLine($"AVG: {statictics.Average}");
Console.WriteLine($"MIN: {statictics.Min}");
Console.WriteLine($"MAX: {statictics.Max}");









