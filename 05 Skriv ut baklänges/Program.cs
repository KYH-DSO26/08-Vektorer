int[] tal = { 10, 20, 30, 40, 50 };

// Loopa baklänges från slutet till början:
for (int i = tal.Length - 1; i >= 0 ; i--)
{
    Console.WriteLine(tal[i]);
    Thread.Sleep(1000);
}





Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();