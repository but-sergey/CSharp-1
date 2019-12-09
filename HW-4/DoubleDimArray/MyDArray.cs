using System;
using System.IO;

namespace DoubleDimArray
{
    public class MyDArray
    {
        public int[,] Arr;

        private Random rand = new Random();

        public MyDArray()
        {
            int Rows = 10;
            int Cols = 10;

            Arr = new int[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Arr[i, j] = rand.Next(100);
                }
            }
        }

        public MyDArray(int Cols, int Rows, int Min, int Max)
        {
            Arr = new int[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Arr[i, j] = rand.Next(Min, Max);
                }
            }
        }

        public MyDArray(int Rows, int Cols, string FileName, out int result)
        {
            try
            {
                if (File.Exists(FileName))
                {
                    string[] FileLines = File.ReadAllLines(FileName);
                    if (FileLines.Length >= Rows * Cols)
                    {
                        Arr = new int[Rows, Cols];

                        for (int i = 0; i < Rows; i++)
                        {
                            for (int j = 0; j < Cols; j++)
                            {
                                Arr[i, j] = Convert.ToInt32(FileLines[i * Rows + j]);
                            }
                        }

                        // Нормальное завершение
                        result = 0;
                    }
                    else
                    {
                        // Размер файла недостаточен
                        result = 2;
                    }
                }
                else
                {
                    // Файл не найден
                    result = 1;
                }
            }
            catch
            {
                // Неизвестная ошибка
                result = 10;
            }
        }

        static public string ResultToStrint(int Result)
        {
            switch (Result)
            {
                case 0:  return "";
                case 1:  return "Файл не найден";
                case 2:  return "Недостаточный размер файла";
                case 10: return "Неизветсная ошибка";
                default: return "Неизвестный код ошибки";
            }
        }

        public void Print()
        {
            for(int i = 0; i < Arr.GetLength(0); i++)
            {
                for(int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write($"{Arr[i, j]}{((j == Arr.GetLength(1)-1) ? "." : ",")}\t");
                }
                Console.WriteLine();
            }
        }

        public int Sum()
        {
            int TSum = 0;
            for(int i=0; i < Arr.GetLength(0); i++)
            {
                for(int j=0; j < Arr.GetLength(1); j++)
                {
                    TSum += Arr[i, j];
                }
            }
            return TSum;
        }

        public int SumBigger(int Num)
        {
            int TSum = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if(Arr[i, j] > Num)
                    {
                        TSum += Arr[i, j];
                    }
                }
            }
            return TSum;
        }

        public void MaxIndex(out int MaxRow, out int MaxCol)
        {
            int Max = Arr[0, 0];
            MaxRow = 0;
            MaxCol = 0;

            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Max < Arr[i, j])
                    {
                        Max = Arr[i, j];
                        MaxRow = i;
                        MaxCol = j;
                    }
                }
            }
        }

        public void MinIndex(out int MinRow, out int MinCol)
        {
            int Min = Arr[0, 0];
            MinRow = 0;
            MinCol = 0;

            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if (Min > Arr[i, j])
                    {
                        Min = Arr[i, j];
                        MinRow = i;
                        MinCol = j;
                    }
                }
            }
        }

        public int Min
        {
            get
            {
                int TMin = Arr[0, 0];
                for(int i = 0; i < Arr.GetLength(0); i++)
                {
                    for(int j=0; j<Arr.GetLength(1); j++)
                    {
                        if(TMin > Arr[i, j])
                        {
                            TMin = Arr[i, j];
                        }
                    }
                }
                return TMin;
            }
        }

        public int Max
        {
            get
            {
                int TMax = Arr[0, 0];
                for (int i = 0; i < Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < Arr.GetLength(1); j++)
                    {
                        if (TMax < Arr[i, j])
                        {
                            TMax = Arr[i, j];
                        }
                    }
                }
                return TMax;
            }
        }
    }
}
