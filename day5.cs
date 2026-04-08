string oddeven(int number)
{
    if(number %2==0)
    {
        return "it is even";
    }
    else
    {
        return  "it is odd";
    }
}
Console.Write("ENTER A NUMBER :");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(oddeven(num));