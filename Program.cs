﻿// Doe de begroeting
Console.WriteLine("**********************************");
Console.WriteLine("Bereken de faculteit van een getal");
Console.WriteLine("**********************************");
Console.WriteLine();
Console.Write("Van welk getal moet de faculteit berekend worden? ");
int getal = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Met welk type iteratie moet de berekening gebeuren?");
Console.WriteLine("   1.  For-loop");
Console.WriteLine("   2.  While-loop");
Console.WriteLine("   3.  Do-While-loop");
Console.WriteLine("   4.  Recursie");
Console.Write("Geef jou keuze: ");
char keuze = Console.ReadLine().First();


long nFaculteit = 1;
int i = 1;


switch (keuze)
{
    case '1':
        // Gebruik een for-loop
        for (int index = getal; index > 1; index--)
        {
            nFaculteit *= index;
        }
        break;
    case '2':
        // Gebruik een while-loop
        while (i <= getal)
        {
            nFaculteit *= i;
            i++;
        }
        break;
    case '3':
        do
        {
            nFaculteit *= i;
            i++;
        } while (i <= getal);
        break;
}

Console.WriteLine();
Console.WriteLine(getal + "! = " + nFaculteit);
Console.WriteLine();
