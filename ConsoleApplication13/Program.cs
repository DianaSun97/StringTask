using System;
namespace ConsoleApplication13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine(Task1.RandomWord("BCDFGHJKLMNPQRSVWXZ",12));
           Console.Write(Task1.RandomWord("BCDFGHJKLMNPQRSVWXZ",5));
           int[] letters=Task2.Task2a("dhtfg",4);
           printArr(letters);
           
           Console.WriteLine(Task1.Sum("erioggr","ioioiejgj"));

        }
        
        public static void printArr(int[] qwerty)
        {
            foreach (int value in qwerty)
            {
                Console.Write(value+" ");
            }
            Console.WriteLine();
        }

    }
}