class Program
{
    public static void Main(string[] args)
    {
        // Task 2 Beginning
        Console.WriteLine("---------------------------");
        Console.WriteLine("Task 2");
        Console.WriteLine("---------------------------");
        int lowerCaseAlphabet = 97;
        int upperCaseAlphabet = 65;
        string[,] alphabet = new string[26, 2];

        for (int i = 0; i < alphabet.GetLength(0); i++)
        {
            for (int j = 0; j < alphabet.GetLength(1); j++)
            {
                Console.Write(alphabet[i, j]);
            }
            Console.WriteLine("");
        }

        // Task 3 Beginning
        for (int i = 0; i < alphabet.GetLength(0); i++)
        {
            alphabet[i, 0] = Convert.ToString((char)upperCaseAlphabet);
            upperCaseAlphabet++;
            for (int j = 1; j < alphabet.GetLength(1); j++)
            {
                alphabet[i, j] = Convert.ToString((char)lowerCaseAlphabet);
                lowerCaseAlphabet++;
            }
        }

        // Task 4 Beginning
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Task 4");
        Console.WriteLine("---------------------------");
        for (int i = 0; i < alphabet.GetLength(0); i++)
        {
            for (int j = 0; j < alphabet.GetLength(1); j++)
            {
                Console.Write($" {alphabet[i, j]}");
            }
            Console.WriteLine("");
        }
    }
}