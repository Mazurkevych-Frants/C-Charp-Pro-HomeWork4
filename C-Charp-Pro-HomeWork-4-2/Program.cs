//Задание 2
//Создайте и опишите класс «Город».
//Выполните перегрузку
//+ (для увеличения количества жителей на указанное количество),
//– (для уменьшения количества жителей на указанное количество),
//== и != (проверка на равенство/не равенство двух городов по количеству жителей),
//< и > (проверка на меньшее или большее количество жителей),
//Используйте механизм свойств полей класса.

using C_Charp_Pro_HomeWork4_2;

public static class Program
{
    public static void Main()
    {
        City city1 = new City("Odessa", 993);
        City city2 = new City("Lviv", 711);

        Console.WriteLine($"В городе {city1.nameCity} проживает: {city1.population}к жителей");
        Console.WriteLine($"В городе {city2.nameCity} проживает: {city2.population}к жителей");

        Console.WriteLine();

        city1 += 32;
        Console.WriteLine($"В городе {city1.nameCity} проживает: {city1.population}к жителей");

        city2 -= 23;
        Console.WriteLine($"В городе {city2.nameCity} проживает: {city2.population}к жителей");

        Console.WriteLine();

        bool result = city1.population == city2.population;
        Console.WriteLine($"В городе {city1.nameCity} и {city2.nameCity} одинаковое количество жителей? - {result}");

        result = city1.population != city2.population;
        Console.WriteLine($"В городе {city1.nameCity} и {city2.nameCity} неодинаковое количество жителей? - {result}");

        result = city1.population > city2.population;
        Console.WriteLine($"В городе {city1.nameCity} больше жителей чем в {city2.nameCity}? - {result}");

        result = city1.population < city2.population;
        Console.WriteLine($"В городе {city1.nameCity} меньше жителей чем в {city2.nameCity}? - {result}");
    }
}