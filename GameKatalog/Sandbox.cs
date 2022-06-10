using static System.Console;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace GameKatalog
{
    class Sandbox : Game
    {
        string PathSandbox = @"C:\Users\Night_Fox\source\repos\GameKatalog\GameKatalog\SandboxList.txt";
        public Sandbox(string Name, string value, string studio, string publisher, string date) : base(Name, value, studio, publisher, date)
        {
        }

        public void SandboxWatch()
        {

            while (flag)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Пiсочницi");
                Console.WriteLine("1.Переглянути каталог Пiсочниць");
                Console.WriteLine("2.Додати гру до каталогу");
                Console.WriteLine("3.Повернутись на головну сторiнку");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\nОберiть код дiї: ");
                index = Convert.ToInt32(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        Console.Clear();
                        var a = new StreamReader(PathSandbox);
                        Console.WriteLine(a.ReadToEnd());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        SandboxKatalog();
                        break;
                    case 3:
                        Console.Clear();

                        return;
                    default:
                        Console.Clear();
                        break;
                }

            }

        }
        public void SandboxKatalog()
        {
            while (flag)
            {
                Console.WriteLine("Ввести назву гри: ");
                Name = ReadLine();
                Console.WriteLine("Ввести студiю розробник гри: ");
                Studio = ReadLine();
                Console.WriteLine("Ввести видавництво гри: ");
                Publisher = ReadLine();
                Console.WriteLine("Ввести дату вихода гри: ");
                Date = ReadLine();
                Console.WriteLine("Ввести вартiсть гри: ");
                Value = ReadLine();

                Console.WriteLine("\n1.Зберiгти данi");
                Console.WriteLine("2.Незберiгати");

                if (String.IsNullOrWhiteSpace(Name) || String.IsNullOrWhiteSpace(Studio) || String.IsNullOrWhiteSpace(Publisher) ||
                 String.IsNullOrWhiteSpace(Date) || String.IsNullOrWhiteSpace(Value))
                {
                    index = 2;
                    Console.Clear();
                    Console.WriteLine("Ви ввели невiрнi данi");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("\n\n\nВведiть код дiї: ");
                    index = Convert.ToInt32(Console.ReadLine());
                }



                switch (index)
                {
                    case 1:
                        using (StreamWriter streamWriter = new StreamWriter(Path, true))
                        {
                            using (StreamWriter streamwriter = new StreamWriter(PathSandbox, true))
                            {
                                streamWriter.WriteLine($"Назва: {Name},Студiя розробник: {Studio},Видавництво: {Publisher},Дата виходу: {Date},Вартiсть: {Value}");
                            }
                        }
                        flag = false;
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();

                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ви ввели неправильний код дiї");
                        Console.WriteLine("Введiть код будьласка знову");
                        Console.ReadLine();
                        break;
                }
            }
        }

    }
}
