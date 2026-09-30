List<string> användare = new List<string>
{
    "admin",
    "kalle",
    "anna_konda",
    "test_user",
    "dev_guru",
};

Console.Write("Ange användarnamn som ska tas bort: ");
string attTaBort = Console.ReadLine();

if (användare.Remove(attTaBort))
{
    Console.WriteLine("Borttagningen lyckades.");
}
else
{
    Console.WriteLine("Borttagningen lyckades inte");
}

Console.WriteLine("\nAktuella användare kvar i systemet:");
foreach (var a in användare)
{
    Console.WriteLine($"- {a}");
}






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();