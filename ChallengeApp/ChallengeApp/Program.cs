using ChallengeApp;

Employee employee1 = new Employee("Mateusz", "Kowalski", 26);
Employee employee2 = new Employee("Monika", "Sęk" , 31);
Employee employee3 = new Employee("Zuzia", "Graszka" , 42);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(7);
employee1.AddScore(3);
employee1.AddScore(1);

employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(8);
employee2.AddScore(1);

employee3.AddScore(2);
employee3.AddScore(5);
employee3.AddScore(6);
employee3.AddScore(2);
employee3.AddScore(1);

List<Employee> employees = new List<Employee>()
{
employee1, employee2, employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;
 foreach (var employee in employees)
{
if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownikiem z największą liczbą punktów jest " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + ", wiek: " + employeeWithMaxResult.Age + " z liczbą punktów " +employeeWithMaxResult.Result);
