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
                    DecoratorStream decorStream = new ReadPasswordStream(new ReadWithPercentStream(fileStream), Console.ReadLine());
                    Console.WriteLine("Считано процентов: "+decorStream.Read(array, 0, array.Length-1));
                    string text = System.Text.Encoding.Default.GetString(array);
                   Console.WriteLine("В файле содержится текст : "+text);
                }
 
            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка:" + e.Message);
            }
            Console.ReadLine();
        }

        
    }
}
