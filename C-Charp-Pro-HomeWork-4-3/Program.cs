//Задание 3
//Создайте и опишите класс «Кредитная карта».
//Добавьте к уже созданному классу информацию о сумме денег на карте.
//Выполните перегрузку
//+ (для увеличения суммы денег на указанное количество),
//– (для уменьшения суммы денег на указанное количество),
//== и != (проверка на равенство/не равенство CVC кода),
//< и > (проверка на меньшее или большее количество суммы денег),
//Используйте механизм свойств полей класса.

using C_Charp_Pro_HomeWork4_3;

public static class Program
{
    public static void Main()
    {
        CreditСard card1 = new CreditСard(103, 55200);
        CreditСard card2 = new CreditСard(266, 74030);

        Console.WriteLine($"Баланс карты 1: ${card1.accountBalance}");
        Console.WriteLine($"Баланс карты 2: ${card2.accountBalance}");

        Console.WriteLine();

        card1 = card1 + 2000;
        Console.WriteLine($"После пополнения, баланс карты 1: ${card1.accountBalance}");

        card2 = card2 - 3000;
        Console.WriteLine($"После снятия, баланс карты 2: ${card2.accountBalance}");

        Console.WriteLine();

        bool result = card1 == card2;
        Console.WriteLine($"Карты имеют одинаковый CVC? - {result}");

        result = card1 != card2;
        Console.WriteLine($"Карты имеют разный CVC? - {result}");

        result = card1 > card2;
        Console.WriteLine($"Баланс карты 1 больше, чем у карты 2? - {result}");

        result = card1 < card2;
        Console.WriteLine($"Баланс карты 1 меньше, чем у карты 2? - {result}");
    }
}