// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

class Program
{
    static void Main (string[] args)
{
        Console.WriteLine("<<<兩位數相加>>>");
        string input1,input2;
        int num1,num2;
        Console.Write("數字一:");
        input1 = Console.ReadLine();
        num1=Convert.ToInt32 (input1);
        Console.Write("數字二:");
        input2 = Console.ReadLine();
        num2 = Convert.ToInt32(input2);
        int result=num1 + num2;
        Console.Write(num1);
        Console.Write("+");
        Console.Write(num2);
        Console.Write("=");
        Console.Write(result+"\n");
        Console.WriteLine(num1 +"+"+ num2+"="+result);
        Console.WriteLine("{0}+{1}+{2}",num1,num2,result);

    }
}