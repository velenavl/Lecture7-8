// Собрать строчку с числами от а до b, а >= b

string NumbersFor(int a, int b) // итеративный подход (итерации)
{
    string result = string.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b) // рекурсия
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1
