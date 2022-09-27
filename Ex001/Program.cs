// Собрать строчку с числами от а до b, а <= b

string NumbersFor(int a, int b) // итеративный подход (итерации)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b) // рекурсия
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10
