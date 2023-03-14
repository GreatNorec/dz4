//Не совсем понимаю зачем реализовывать задачу через цикл, мне показалось проще через математическую функцию

int A = 3;
int B = 5;

double MetodPow(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}

Console.WriteLine(MetodPow(A, B));

//Так же решил реализовать через цикл

double forPow(int A, int B)
{
    double result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.WriteLine(forPow(A, B));