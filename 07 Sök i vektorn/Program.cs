string[] städer = { "Göteborg", "Stockholm", "Härnösand", "Gävle", "Halmstad", "Sollefteå" };

Console.Write("Mata in en stad att söka efter: ");
string sökning = Console.ReadLine();
bool hittad = false;

for (int i = 0; i < städer.Length; i++)
{
    //if (städer[i].Equals(sökning, StringComparison.OrdinalIgnoreCase))  // Skiftlägesokänslig jämförelse
    if (städer[i].ToLower() == sökning.ToLower())
    {
        Console.WriteLine($"Staden hittades på index: {i}");
        hittad = true;
        break;
    }
}

if (hittad == false)
{
    Console.WriteLine("Staden finns tyvärr inte med på listan.");
}






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();