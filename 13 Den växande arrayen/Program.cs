int[] minArray = new int[3];
int antalElement = 0;

while (true)
{
    Console.Write("Mata in ett heltal (eller skriv 'avsluta'): ");
    string svar = Console.ReadLine();
    if (svar.ToLower() == "avsluta") break;

    if (int.TryParse(svar, out int tal))
    {
        // Kontrollera om arrayen är full och behöver expandera
        if (antalElement == minArray.Length)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[INFO] Arrayen full ({minArray.Length} st). Expanderar storleken till det dubbla!");
            Console.ResetColor();

            int[] nyStoreArray = new int[minArray.Length * 2];
            Array.Copy(minArray, nyStoreArray, minArray.Length);
            minArray = nyStoreArray;    // Ersätt den gamla arrayen med den nya
        }

        minArray[antalElement] = tal;
        antalElement++;
    }
}

Console.WriteLine("Arrayen innehåller:");
//for (int i = 0; i < minArray.Length; i++)
for (int i = 0; i < antalElement; i++)
{
    Console.WriteLine($"- {i} {minArray[i]}");
}







#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

#endregion