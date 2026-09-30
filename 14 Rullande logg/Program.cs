string[] logg = new string[5];
// Lägg till några exempelmeddelanden via en säker metod
LäggTillLogg(logg, "Systemet startade");
LäggTillLogg(logg, "Användare loggade in");
LäggTillLogg(logg, "Databasanslutning lyckades");
LäggTillLogg(logg, "Varning: Låg minneskapacitet");
LäggTillLogg(logg, "Fel: Kunde inte ladda konfiguration");
// Nu är den full - nästa kommer putta ut det äldsta
LäggTillLogg(logg, "NYTT FEL: Kritisk överbelastning");

void LäggTillLogg(string[] rullandeLogg, string nyttMeddelande)
{
    // Kontrollera om sista platsen är upptagen (dvs listan är full)
    if (rullandeLogg[rullandeLogg.Length - 1] != null)
    {
        // Skifta alla element ett steg till vänster
        for (int i = 0; i < rullandeLogg.Length - 1; i++)
        {
            rullandeLogg[i] = rullandeLogg[i + 1];
        }
        // Lägg det nya meddelandet på den sista platsen
        rullandeLogg[rullandeLogg.Length - 1] = nyttMeddelande;
    }
    else
    {
        // Hitta första lediga plats och lägg till det där
        for (int i = 0; i < rullandeLogg.Length; i++)
        {
            if (rullandeLogg[i] == null)
            {
                rullandeLogg[i] = nyttMeddelande; break;
            }
        }
    }
}

Console.WriteLine("Aktuell rullande logg:");
foreach (string rad in logg)
{
    Console.WriteLine($"- {rad}");
}




#region Extrarader
Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

#endregion