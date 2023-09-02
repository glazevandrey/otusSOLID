using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otusSOLID.Interfaces;

namespace otusSOLID.GameCommands
{
    internal class PlayGameCommand : IGameCommand
    {
        private readonly BaseGenerator _generator;
        public PlayGameCommand(BaseGenerator generator)
        {
            _generator = generator;
        }

        public void Execute()
        {
            var random_num = _generator.GetRandomNumber();
            var attemps = _generator.GeneratorSettings.AttempsCount;

            Console.WriteLine("Число сгенерированно! Угадывайте какое!");
            while (true)
            {

                Console.WriteLine("Введите число:");
                var num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (num == random_num)
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("!!!ПОЗДРАВЯЛЕМ!!! ВЫ ПОБЕДИЛИ!!!");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Возвращение в главное меню...");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    return;
                }

                if(num < random_num)
                {
                    Console.WriteLine("Названное вами число - меньше загаданного");
                    attemps--;
                }
                if (num > random_num)
                {
                    Console.WriteLine("Названное вами число - больше загаданного");
                    attemps--;
                }


                if (attemps == 0)
                {
                    Console.WriteLine("К сожалению, вы проиграли =(");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Возвращение в главное меню...");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    return;
                }
                else
                {
                    Console.WriteLine($"Осталось попыток: {attemps}");
                }
            }
        }
    }
}
