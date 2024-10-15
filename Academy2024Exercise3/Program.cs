/*
 creare un programma che legge in input dall'utente un numero intero positivo (senza segno) 
e che continui a chiedergli il numero nel caso in cui risulti non valido o dispari. Non appena
un numero pari viene inserit, dice all'utente (tramite WriteLine ) "bravo hai inserito un numero pari". fine del programa.
 */

uint number = 0;
bool isValid = false;

/*
while (!isValid )
{
    Console.Write("Insert number: ");
    isValid = uint.TryParse(Console.ReadLine(), out number);

    if (!isValid)
    {
        Console.WriteLine("the number invalid");
    }
    else if (number % 2 == 0)
    {
        Console.WriteLine("GOOD, you entered an even number");
    }
    else
    {
        Console.WriteLine("the number is odd, insert an even number ");
        isValid = false;
    }
 
}
*/

do
{
    Console.Write("Insert number: ");
    isValid = uint.TryParse(Console.ReadLine(), out number);
}
while (!isValid || number % 2 !=0);

Console.WriteLine("GOOD, you entered an even number");