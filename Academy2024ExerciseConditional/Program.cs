
using System.Collections.Generic;

/*  creare un programma nel quale vengono presi in input due numeri dall'utente,
dopodiché dire all'utente (tramite Console.Write o WrileLine) quale tra i due è il maggiore o se sono uguali
*/

int firstNumber;
bool isNum1Valid;

do
{
    Console.Write("Insert first number: ");
    isNum1Valid = int.TryParse(Console.ReadLine(), out firstNumber);
    if (!isNum1Valid)
    {
        Console.WriteLine("the number invalid");
    }
}
while (!isNum1Valid);

int secondNumber;
bool isNum2Valid;

do
{
    Console.Write("Insert second number: ");
    string secondNumberInput = Console.ReadLine();
    isNum2Valid = int.TryParse(secondNumberInput, out secondNumber);
    if (!isNum2Valid)
    {
        Console.WriteLine("the number invalid");
    }
}
while (!isNum2Valid);


if (firstNumber > secondNumber)
{
    Console.WriteLine($"The first number {firstNumber} is greater than the second number");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine($"The second number {secondNumber} is greater than the first number");
}
else
{
    Console.WriteLine($"The first number {firstNumber} is the same as the second number");
}
