// С#. Уровень 1
// Домашнее задание к уроку 5
// Бут Сергей
//
// === Задание 02 ===
//
// Разработать класс Message, содержащий следующие статические методы для обработки
// текста:
// а) Вывести только те слова сообщения, которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// Продемонстрируйте работу программы на текстовом файле с вашей программой.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task02
{
    class Message
    {
        static public string[] GetWordsLess(string[] inString, int Letters)
        {
            string[] toOut = new string[0];

            // цикл по строкам в массиве
            for (int i = 0; i < inString.Length; i++)
            {
                string tempStr = "";
                // цикл по символам строки
                for (int j = 0; j < inString[i].Length; j++)
                {
                    if (Char.IsLetter(inString[i][j]))
                    {
                        tempStr = String.Concat(tempStr, inString[i][j]);
                    }
                    if ((!Char.IsLetter(inString[i][j])) || (i == (inString[i].Length - 1)))
                    {
                        if ((tempStr.Length <= Letters) && (tempStr.Length != 0))
                        {
                            Array.Resize(ref toOut, toOut.Length + 1);
                            toOut[toOut.Length - 1] = tempStr;
                        }
                        tempStr = "";
                    }
                }
            }

            return toOut;
        }

        static public string[] DeleteWords(string[] inString, char symbol)
        {
            string[] toOut = new string[0];

            for(int i = 0; i < inString.Length; i++)
            {
                string WorkString = inString[i];
                string tempStr = "";
                int pos = 0;

                while (pos <= WorkString.Length)
                {
                    if ((pos == WorkString.Length) || (!Char.IsLetter(WorkString[pos])))
                    {
                        if (tempStr.Length != 0)
                        {
                            if (tempStr[tempStr.Length - 1] == symbol)
                            {
                                WorkString = WorkString.Remove(pos - tempStr.Length, tempStr.Length);
                                pos = pos - tempStr.Length;
                            }
                            tempStr = "";
                        }
                    }
                    else
                    {
                        tempStr = String.Concat(tempStr, WorkString[pos]);
                    }
                    pos++;
                }
                Array.Resize(ref toOut, toOut.Length + 1);
                toOut[toOut.Length - 1] = WorkString;
            }
            return toOut;
        }

        static public string FindLongestWord(string[] inString, out int NumString)
        {
            string MaxWord = "";
            NumString = 0;

            for (int i = 0; i < inString.Length; i++)
            {
                string WorkString = inString[i];
                string tempStr = "";

                for (int j = 0; j < WorkString.Length; j++)
                {
                    if (Char.IsLetter(WorkString[j]))
                    {
                        tempStr = String.Concat(tempStr, WorkString[j]);
                    }
                    else
                    {
                        if (MaxWord.Length < tempStr.Length)
                        {
                            MaxWord = tempStr;
                            NumString = i;
                        }
                        tempStr = "";
                    }
                }
            }
            return MaxWord;
        }

        static public string FindLongestWord(string[] inString)
        {
            int NumStr = 0;

            return FindLongestWord(inString, out NumStr);
        }

        static public StringBuilder LongestWords(string[] inString, int count)
        {
            StringBuilder toOut = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                int NumStr = 0;
                string MaxWord = FindLongestWord(inString, out NumStr);
                toOut.Append(MaxWord);
                if ((i != count) && (MaxWord.Length != 0))
                {
                    toOut.Append(" ");
                }
                inString[NumStr] = inString[NumStr].Remove(inString[NumStr].IndexOf(MaxWord), MaxWord.Length);
            }

            return toOut;
        }
    }

    class Program
    {
        static void Main()
        {
            string[] Lines = File.ReadAllLines("..\\..\\Program.cs");

            #region LongestWords

            Console.WriteLine($"{Message.LongestWords(Lines, 2)}");

            #endregion

            #region FindLongestWord

            // Console.WriteLine(Message.FindLongestWord(Lines));

            #endregion

            #region DeleteWords

            //string[] LinesAfterDelete = Message.DeleteWords(Lines, 'r');
            //for(int i = 0; i < LinesAfterDelete.Length; i++)
            //{
            //    Console.WriteLine(LinesAfterDelete[i]);
            //}
            
            #endregion

            #region GetWordsLess

            //string[] Words = Message.GetWordsLess(Lines, 5);
            //foreach(string str in Words)
            //{
            //    Console.WriteLine(str);
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
