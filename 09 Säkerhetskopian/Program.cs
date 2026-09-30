string[] originalConfig = { "IP=192.168.1.1", "PORT=8080", "DB=Users", "SSL=True" };
string[] backupConfig = new string[originalConfig.Length];

// Kopiera med Array.Copy
Array.Copy(originalConfig, backupConfig, backupConfig.Length);

//backupConfig = originalConfig;  // FUNKAR INTE - BÅDA ÄNDRAS!

// Ändra i originalet
originalConfig[0] = "IP=10.0.0.1";

Console.WriteLine($"Original index 0: {originalConfig[0]}");
Console.WriteLine($"Backup index 0: {backupConfig[0]} (Oförändrad!)");





Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();