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

    public class Game
    {
        public int index;
        public bool flag = true;
        public string Path = @"C:\Users\Night_Fox\source\repos\GameKatalog\GameKatalog\GameList.txt";
        protected string GameName;
        protected string GameValue;
        protected string GameStudio;
        protected string GamePublisher;
        protected string GameDate;

        public Game(string Name, string value, string studio, string publisher, string date)
        {
            this.GameName = Name;
            this.GameValue = value;
            this.GameStudio = studio;
            this.GamePublisher = publisher;
            this.GameDate = date;
        }

        public string Name
        {
            get { return GameName; }
            set { GameName = value; }
        }

        public string Value
        {
            get { return GameValue; }
            set { GameValue = value; }
        }

        public string Studio
        {
            get { return GameStudio; }
            set { GameStudio = value; }
        }

        public string Publisher
        {
            get { return GamePublisher; }
            set { GamePublisher = value; }
        }

        public string Date
        {
            get { return GameDate; }
            set { GameDate = value; }
        }

        
        public static void Main(string[] args)
        {
            int index;
            bool flag = true;
            string Path = @"C:\Users\Night_Fox\source\repos\GameKatalog\GameKatalog\GameList.txt";
            Roguelike roguelike = new Roguelike(null,null,null,null,null);
            RPG rpg = new RPG(null, null, null, null, null);
            Sandbox sandbox = new Sandbox(null, null, null, null, null);
            Shooter shooter = new Shooter(null,null,null,null,null);
            Strategy strategy = new Strategy(null,null,null,null,null);

            while (flag)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Iгровий каталог");
                Console.WriteLine("1.Переглянути увесь каталог");
                Console.WriteLine("2.Перейти до каталогу Рогаликiв");
                Console.WriteLine("3.Перейти до каталогу Пiсочниць");
                Console.WriteLine("4.Перейти до каталогу РПГ");
                Console.WriteLine("5.Перейти до каталогу Шутерiв");
                Console.WriteLine("6.Перейти до каталогу Стратегій");
                Console.WriteLine("7.Вийти");
                Console.WriteLine("------------------------------------");
                Console.Write("\nОборiть код дiї: ");
                index = Convert.ToInt32(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        Console.Clear();
                        Console.Clear();
                        var a = new StreamReader(Path);
                        Console.WriteLine(a.ReadToEnd());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        roguelike.RoguelikeWatch();
                        break;
                    case 3:
                        Console.Clear();
                        sandbox.SandboxWatch();
                        break;
                    case 4:
                        Console.Clear();
                        rpg.RPGWatch();
                        break;
                    case 5:
                        Console.Clear();
                        shooter.ShooterWatch();
                        break;
                    case 6:
                        Console.Clear();
                        strategy.StrategyWatch();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ви ввели неправильний код дiї");
                        Console.WriteLine("Введiть код будьласка знову");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }

        }

        
    }
}
