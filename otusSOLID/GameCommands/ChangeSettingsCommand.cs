using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otusSOLID.Interfaces;
using otusSOLID.Implementations;

namespace otusSOLID.GameCommands
{
    internal class ChangeSettingsCommand : IGameCommand
    {
        private readonly BaseGenerator _generator;

        // если был бы ASP NET - было бы через DI 
        public ChangeSettingsCommand(BaseGenerator generator)
        {
            _generator = generator;
        }

        public void Execute()
        {
            Console.WriteLine("Введите кол-во попыток: ");
            var attemps = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите диапазон чисел.(напр: 1-20)");
            var str = Console.ReadLine();

            try
            {
                var nums = str.Trim().Split("-");
                var min = Convert.ToInt32(nums[0]);
                var max = Convert.ToInt32(nums[1]);

                _generator.GeneratorSettings.ChangeSettings(attemps, min, max);
            }
            catch
            {
                Console.WriteLine("Необходимо вводить диапазон в формате 'x-y', например, 5-400");
                Console.WriteLine();
                Execute();
            }

            Console.WriteLine("Настройки успешно сохранены!");
        }
    }
}
