string[] element = { "Kaffe", "Te", "Mjölk", "Kaffe", "Bröd", "Te", "Bulle" };
List<string> hittadeDuplikat = new List<string>();

for (int i = 0; i < element.Length; i++)
{
    for (int j = i + 1; j < element.Length; j++)
    {
        if (element[i] == element[j] && !hittadeDuplikat.Contains(element[i]))
        {
            hittadeDuplikat.Add(element[i]);
        }
    }
}

if (hittadeDuplikat.Count > 0)
{
    Console.WriteLine("Följande duplikat hittades:");
    foreach (var d in hittadeDuplikat)
    {
        Console.WriteLine($"- {d}");
    }

}
else
{
    Console.WriteLine("Inga duplikat hittades");
}





#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

#endregion