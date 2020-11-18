using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HappyBirthdayAlina
{
    class Program
    {

        private static void HappyBirthday()
        {
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(1200, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }

        private static async void AsyncTextWriter()
        {
            string txt = "Алина, поздравляю тебя с 18-летием!\n" +
                "Твои друзья придумали классную идею." +
                "\nЯ желаю тебе оставаться энергичной\nПозитивной" +
                "\nИ целеустремленной\n" +
                "Относиться спокойно к тому, что тебе неподвластно;\n" +
                "Успехов в любых твоих начинаниях,\nА главное - здоровья!";
            string[] ar = txt.Split('\n');
            void Work()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Title = "Happy Birthday, Alina";
                foreach (var i in ar)
                {
                    Console.WriteLine($"\t{i}\n");
                    Thread.Sleep(1800);
                }
            }
            await Task.Run(() => Work());
        }


        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            AsyncTextWriter();
            HappyBirthday();
            Console.ReadKey();
        }
    }
}
