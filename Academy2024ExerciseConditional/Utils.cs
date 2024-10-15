

namespace Academy2024ExerciseConditional;

public static class Utils
{
    public static int AskForInt(string promt)
    {
        int number;
        bool isValid;

        do
        {
            Console.Write(promt);
            isValid = int.TryParse(Console.ReadLine(), out number);
            if (!isValid)
            {
                Console.WriteLine("the number invalid");
            }
        }
        while (!isValid);

        return number;

    }
}
