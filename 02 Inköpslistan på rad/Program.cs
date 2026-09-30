string[] inköpslista = { "Kaffe", "Mjölk", "Bröd", "Ägg", "Öl" };

for (int i = 0; i < inköpslista.Length; i++)
{
    Console.WriteLine($"{i}: {inköpslista[i]}");
}





Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();