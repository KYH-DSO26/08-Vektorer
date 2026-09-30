int[] provpoäng = { 45, 38, 50, 29, 42, 39, 15 };
int summa = 0;

foreach (var poäng  in provpoäng)
{
    summa += poäng;
}

// Tyåkonvertering till double för att behålla decimaler
double medelvärde = (double)summa / provpoäng.Length;

Console.WriteLine($"Medelpoängen är: {medelvärde:F1}");

// Med LINQ blir det kortare:
var avg = provpoäng.Average();
Console.WriteLine($"Medelpoäng med LINQ: {avg:F1}");






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();