const int SIZE = 5;

int[] siffror = new int[SIZE];
int index = 0;

while (index < siffror.Length)
{
    Console.Write($"Mata in ett heltal för index {index}: ");
    string indata = Console.ReadLine();

    if (int.TryParse(indata, out int tal))
    {
        siffror[index] = tal;
        index++;    // Gå vidare till nästa index bara om inmatn ingen var korrekt
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktig inmatning! Det måste vara ett heltal. Försök igen.");
        Console.ResetColor();
    }
}

Console.WriteLine("\n\nArrayen är full: Innehåll:");
for (int i = 0; i < siffror.Length; i++)
{
    Console.WriteLine($"Index {i}: {siffror[i]}");
}
//int i = 0;
//foreach (var tal in siffror)
//{
//    Console.WriteLine($"Index {i}: {tal}");
//    i++;
//}




#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

#endregion