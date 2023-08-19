string name = "Ewa";
string gender = "kobieta";
int age = 33;

if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender != "kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine(" Ktoś zupełnie inny");
}

//Mateusz