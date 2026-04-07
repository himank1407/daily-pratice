Console.Write("ENTER THE SIZE OF ARRAY: ");
int size=Convert.ToInt32(Console.ReadLine());
int[] arr=new int [size];
for(int i=0;i<size;i++)
{
   Console.Write("ENTER "+(i+1)+" ELEMENT OF ARRAY: ");
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int maxi=int.MinValue,secondlargest;
for(int i=0;i<size;i++)
{
    if(arr[i]>maxi)
    {
        secondlargest = maxi;
        maxi = arr[i];
    }
    else if(arr[i] > secondlargest && arr[i] != maxi)
    {
        secondlargest = arr[i];
    }
}
Console.WriteLine("LARGEST ELEMENT IN ARRAY IS: "+maxi);
Console.WriteLine(" SECOND LARGEST ELEMENT IN ARRAY IS: "+secondlargest);
