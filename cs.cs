Console.Write("Artikelname: ");
string artikel = Console.ReadLine();
Console.Write("Einzelpreis (CHF): ");
decimal einzelpreis = decimal.Parse(Console.ReadLine());
Console.Write("Menge: ");
int menge = int.Parse(Console.ReadLine());
if (menge < 1)
{
    Console.WriteLine("Fehler: Menge muss mindestens 1 sein.");
    return;
}
decimal gesamtpreis = einzelpreis * menge;
decimal rabatt = 0;
if (menge >= 5)
{
    rabatt = 0.20m;
}
else if (menge >= 3)
{
    rabatt = 0.10m;
}
else
{
    rabatt = 0;
}
decimal rabattbetrag = gesamtpreis * rabatt;
decimal endpreis = gesamtpreis - rabattbetrag;
Console.WriteLine("Artikel: " + artikel);
Console.WriteLine("Gesamtpreis: CHF" + gesamtpreis.ToString("0.00"));
Console.WriteLine("Rabatt: " + (rabatt * 100).ToString("0.00") + "%");
Console.WriteLine("Rabattbetrag: CHF" + rabattbetrag.ToString("0.00"));
Console.WriteLine("Endpreis: CHF" + endpreis.ToString("0.00"));