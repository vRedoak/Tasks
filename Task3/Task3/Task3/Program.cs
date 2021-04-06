using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream fileStream = File.OpenRead(@"..\..\..\file.txt"))
                {
                    byte[] array = new byte[fileStream.Length];
                    Console.WriteLine("Введите пароль: ");
                    ReadWithPercentStream decorStream = new ReadWithPercentStream(new ReadPasswordStream((fileStream), Console.ReadLine()), PercentToConsole);
                    decorStream.Read(array, 0, array.Length);
                    string text = System.Text.Encoding.Default.GetString(array);
                    Console.WriteLine("В файле содержится текст : " + text);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка:" + e.Message);
            }
            Console.ReadLine();
        }

        public static void PercentToConsole(int percent)
        {
            Console.WriteLine("Прочитано " + percent + "% файла ");
        }

    }
}
