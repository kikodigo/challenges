using Challenges.Calculator;
using Challenges.Util;

var _menu = new MenuConstruct();
var _calculator = new Calculator();

_menu.MenuConstruction("Challenges");
Console.WriteLine("Selecione um dos Desafios");
Console.WriteLine("1 - Calculadora");

int.TryParse(Console.ReadLine(), out int option);

switch (option)
{
    case 1:
        _calculator.CalculatorChallenges();
        break;

    default:
        Console.WriteLine("Opção Invalida");
        break;
}


