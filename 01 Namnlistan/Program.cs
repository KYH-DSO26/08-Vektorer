string[] namn = new string[5];
namn[0] = "Anna";
namn[1] = "Bilal";
namn[2] = "Cecilia";
namn[3] = "David";
namn[4] = "Elisabeth";

Console.WriteLine($"Första namnet: {namn[0]}");
Console.WriteLine($"Sista namnet: {namn[namn.Length - 1]}");
//Console.WriteLine(namn.First());
//Console.WriteLine(namn.Last());






Console.Write("Tryck på en tangent för att stänga fönstret...");
Console.ReadKey();