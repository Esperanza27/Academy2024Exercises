using System.Collections.Generic;
using System.Drawing;


/*creare un programma che prenda in input dall'utente i due lati di un triangolo rettangolo
e che vada a calcolare l'ipotenusa tramite il teorema di pitagora:
ipotenusa = sqrt(lato1*lato1 + lato2*lato2).
Stampare il risultato all'utente.
*/


Console.Write("Insert base side length: ");
string baseSideInput = Console.ReadLine();
double baseSide = double.Parse(baseSideInput);
// controlli di guardia 
if (baseSide < 0 || baseSide > 20)
{
    Console.WriteLine("YOU INSERTED AN INVALID BASE SIDE");
    return;
}

Console.Write("Insert height side length: ");
string heightSideInput = Console.ReadLine();
double heightSide = double.Parse(heightSideInput);
if (heightSide < 0)
{
    Console.WriteLine("YOU INSERTED A BASE SIDE");
    return;
}

double hypotenuse = Math.Sqrt(Math.Pow(baseSide, 2) + Math.Pow(heightSide, 2));

Console.WriteLine($"Hypotenuse:  {hypotenuse} cm");
Console.WriteLine();






