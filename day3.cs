void recu(int n, int value)
{
    if (n == value)
    {
        Console.WriteLine(n);
        return;
    }

    recu(n + 1, value);
    Console.WriteLine(n);
}

recu(1, 10);