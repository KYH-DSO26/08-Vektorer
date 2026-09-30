int[] tal = { 1, 2, 3, 4, 5 };
// Spara undan det allra sista elementet som annars skrivs över
int sistaElementet = tal[tal.Length - 1];

// Skifta elementen från höger till vänster, starta från slutet
for (int i = tal.Length - 1; i > 0; i--)
{
    tal[i] = tal[i - 1];
}

// Sätt det sparade sista elementet på den första positionen
tal[0] = sistaElementet;

Console.WriteLine("Roterad array:");
foreach (int t in tal)
{
    Console.Write(t + " "); // Skriver ut: 5 1 2 3 4
}






#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

#endregion