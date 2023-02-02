using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_02._02._23_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 20);
            int unic = 0;
            bool check = true;
            string buf_c = "", buf_uc = "", buf_unic = "";
            Console.Write("Массив: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    buf_c += arr[i].ToString() + " ";
                else if (arr[i] % 2 != 0)
                    buf_uc += arr[i].ToString() + " ";
                unic = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (unic == arr[j])
                        check = false;
                }
                if (check)
                    buf_unic += unic.ToString() + " ";
                check = true;
            }
            Console.WriteLine("Четные: {0}\nНечетные: {1}\nУникальные: {2}", buf_c, buf_uc, buf_unic);
            #endregion

            #region Задача 2
            Console.Write("\nВведите максимальное значение: ");
            int max = Convert.ToInt32(Console.ReadLine());
            string buf_2 = "";
            for(int i = 0; i < arr.Length; i++)
            {
                if (max > arr[i])
                    buf_2 += arr[i].ToString() + " ";
            }
            Console.WriteLine($"Результат: {buf_2}");
            #endregion

            #region Задача 3
            Console.WriteLine("Введите последовательность чисел: ");
            string buf_3 = Console.ReadLine();
            string buf_3_arr = "";
            int count = 0, index = 0;
            for (int i = 0; i < arr.Length; i++)
                buf_3_arr += arr[i].ToString() + " ";
            for(int i = 0; i < buf_3_arr.Length; i++)
            {
                if (buf_3_arr.IndexOf(buf_3) > -1 + index)
                {
                    count++;
                    index = buf_3_arr.IndexOf(buf_3) + 1;
                }
            }
            Console.WriteLine($"Кол-во повторов = {count}");
            #endregion
        }
    }
}
