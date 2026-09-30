List<string> gäster = new List<string>();
gäster.Add("Johan");
gäster.Add("Magnus");
gäster.Add("Patrik");
gäster.Add("Anna");
gäster.Add("Carl");


Console.WriteLine($"Antal anmälda gäster: {gäster.Count}");
Console.WriteLine($"Gästlistan har plats för {gäster.Capacity} gäster");

foreach (var gäst in gäster)
{
    Console.WriteLine(gäst);
}




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();