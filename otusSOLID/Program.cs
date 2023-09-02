using otusSOLID;
using otusSOLID.GameCommands;
using otusSOLID.Interfaces;
using otusSOLID.Implementations;

BaseSettings _settings = new GeneratorSettings(5, 0, 10);
BaseGenerator _generator = new Generator(_settings);
ICommandExecutor _commandExecutor = new CommandExecutor();

while (true)
{
    Console.WriteLine("Главное меню игры УГАДАЙ ЧИСЛО!");
    Console.WriteLine();


    Console.WriteLine($"Текущие правила игры: {_generator.GeneratorSettings.AttempsCount} попыток, угадать число от {_generator.GeneratorSettings.MinNumber} до {_generator.GeneratorSettings.MaxNumber}. При каждой попытке будет писаться меньше либо больше число названное вами.");
    Console.WriteLine("Выберите необходимое действие:");
    Console.WriteLine("1. Настроки   2. Играть");

    var way = Convert.ToInt32(Console.ReadLine());

    if (way == 1)
    {
        _commandExecutor.Add(new ChangeSettingsCommand(_generator));
    }
    else if (way == 2)
    {
        _commandExecutor.Add(new PlayGameCommand(_generator));
    }

    _commandExecutor.Execute();

    Console.WriteLine();
    Console.WriteLine();
}
