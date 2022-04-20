using System;
namespace ConsoleApplication13
{
    public class Task1
    {
        public static string RandomWord(string Alphabet, int Length)
        {
            //создать две строки случайной четной длины и заполнить случайными символами
           

            // 1.Создаем генератор случайных чисел.
            Random rand = new Random();
            
            // 2.Создаем массив букв, которые мы будем использовать.
            char[] letters = Alphabet.ToCharArray();
            
            //3.переменная для хранения случайной символовов из строки 
            string A = "";

            //Цикл 
            for (int i = 0; i < Length; i++)
            {
                int ind = rand.Next(0, letters.Length);
                A=A+letters[ind];
            }
            return A;
        }
        
       
        
        public static string Sum(string randomWord,string randomWord1)
        {
            //создать третью строку из первой половины первой строки и второй половины второй строки
            string randomWord2 = randomWord1.Substring(randomWord1.Length / 2);
            
            //2строка
            string randomWord3 = randomWord.Substring(0,randomWord.Length/2);

            string randomWord4 = randomWord3 + randomWord2;

            return randomWord4;
        }
        
    }
}