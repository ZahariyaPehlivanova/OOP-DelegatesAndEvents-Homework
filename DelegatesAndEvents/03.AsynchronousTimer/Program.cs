using System;
namespace _03.AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTimer printWord = new AsyncTimer(PrintWord, 10, 500);
            printWord.Execute();
        }
        private static void PrintWord(int i)
        {
            Console.WriteLine("Hello C#! {0}",i);
        }
    }
}
