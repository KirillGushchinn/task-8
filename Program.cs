using System;

public class Zadanie8
{
    public static void Main(string[] args)
    {
        int N,i;
        i=1;
        Console.Write ("Введите число N=");
        N=int.Parse(Console.ReadLine());
        Console.Write("N=");
        while (i<N){
         if (i%2==0){
             Console.Write($"{i} ");
         }   
             i++;
        }
    }
}
