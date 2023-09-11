using System.ComponentModel.Design;

var name = "Ewa";
var age = 33;
string sex = "kobieta";

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (age < 18 && sex != "kobieta")
{
    Console.WriteLine(" Niepełnoletni mężczyzna");
}