double[] temperaturer = { 15.5, 18.2, 14.0, 21.3, 19.8, 16.5, 17.1 };
//double högsta = temperaturer[0];
double högsta = double.MinValue;

for (int i = 0; i < temperaturer.Length; i++)
{
    if (temperaturer[i] > högsta)
    {
        högsta = temperaturer[i];
    }
}

Console.WriteLine($"Veckans högsta temperatur: {högsta} grader.");





Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();