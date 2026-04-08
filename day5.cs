string oddeven(int number)
{
    if(number %2==0)
    {
        return "IT IS EVEN NUMBER";
    }
    else
    {
        return  "IT IS ODD NUMBER";
    }
}
string prime(int number)
{
    for(int i=2;i<number/2;i++)
    {
        if(number%i==0)
        {
            return " IT IS NOT A PRIME NUMBER";
        }
    }
    return " IT IS A PRIME NUMBER";
}
Console.Write("ENTER A NUMBER :");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(oddeven(num));
Console.WriteLine(prime(num));