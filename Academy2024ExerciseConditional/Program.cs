
using Academy2024ExerciseConditional;
using System.Collections.Generic;

/*  creare un programma nel quale vengono presi in input due numeri dall'utente,
dopodiché dire all'utente (tramite Console.Write o WrileLine) quale tra i due è il maggiore o se sono uguali
*/
int firstNumber = Utils.AskForInt("Insert first number: ");
int secondNumber = Utils.AskForInt("Insert second number: ");

/*
int firstNumber;
bool isValid;

do
{
    Console.Write("Insert first number: ");
    isValid = int.TryParse(Console.ReadLine(), out firstNumber);
    if (!isValid)
    {
        Console.WriteLine("the number invalid");
    }
}
while (!isValid);

int secondNumber;

do
{
    Console.Write("Insert second number: ");
    string secondNumberInput = Console.ReadLine();
    isValid = int.TryParse(secondNumberInput, out secondNumber);
    if (!isValid)
    {
        Console.WriteLine("the number invalid");
    }
}
while (!isValid);
*/

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
