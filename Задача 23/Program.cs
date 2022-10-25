using System;
class MyProgram
{

    static string getThirdDegree(int N)
    {
        string result = "";
        for (int i = 1; i < N; i++)
        {
            result += (i * i * i).ToString() + ", ";
        }
        result += (N * N * N).ToString();
        return result;
    }

    static void Main()
    {
        Console.Write("Введите N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n} -> {getThirdDegree(n)}");

    }
}
