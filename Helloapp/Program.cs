using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = { 10, 7, 17, 13, 14, 28, 5 };
        int temp;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp=arr[j];
                    arr[j]=arr[j + 1];
                    arr[j+1]=temp;
                }
            }
        }
        foreach(int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}
