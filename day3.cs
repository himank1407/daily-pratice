// int recu(int value)
// {
//     if(n==value)
//     {
//         Console.WriteLine(n);
//         return;
//     }
//     else
//     {
//         recu(n+1);
//         Console.WriteLine(n);

//     }
// }
// recu(10);

void recu(int n, int value)
{
    if (n == value)
    {
        Console.WriteLine(n);
        return;
    }

    Console.WriteLine(n);
    recu(n + 1, value);
    Console.WriteLine(n);
}

recu(1, 10);