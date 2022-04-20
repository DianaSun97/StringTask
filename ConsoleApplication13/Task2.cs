using System;
namespace ConsoleApplication13
{
    public class Task2
    {
        //создать случайную строку
        //посчитать вхождение каждого символа (через массив)

        public static int[] Task2a(string Alphabet,int Length)
        {
            string RandWord = Task1.RandomWord(Alphabet,Length);
            char[] symbol = RandWord.ToCharArray();
            int[] arr = new int[Alphabet.Length];

            foreach (char word in symbol)
            {
                int index = Alphabet.IndexOf(word);
                arr[index]++;
            }
        return arr;
        }
    }
}