Console.WriteLine("Введите число дня недели");
string week = Console.ReadLine();

switch (week)
{
    case "1":
    case "2":
    case "3":
    case "4":
    case "5":
    Console.WriteLine("нет");
    break;
    case "6":
    case "7":
    Console.WriteLine("да");
    break;
    default:
    Console.WriteLine("Ввели не правильное число, нужно от 1 до 7");
    break;
}