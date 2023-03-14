int Sum()
{
    Console.Write("Введите число для которого будем искать сумму цифр внутри него: ");
    string num = Console.ReadLine();
    int N = int.Parse(num);
    int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
        result = result + N % 10;
        N = N / 10;
    }
    return result;
}

Console.WriteLine(Sum());