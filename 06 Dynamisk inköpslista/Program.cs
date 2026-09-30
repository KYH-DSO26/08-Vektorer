List<string> inköpslista = new List<string>();

while (true)
{
    Console.Write("Lägg till en sak (eller skriv 'klar': ");
    var inmatning = Console.ReadLine();

    if (inmatning.ToLower() == "klar")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(inmatning) == false)  // Acceptera inte tomma rader
    {
        inköpslista.Add(inmatning);
    }
}

Console.WriteLine("\nDin kompletta inköpslista:");
foreach (var sak in inköpslista)
{
    Console.WriteLine($"- {sak}");
}






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();