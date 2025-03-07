//Задание 1
//Создайте и опишите класс «Сотрудник».
//Добавьте в уже созданный класс информацию о заработной плате работника.
//Выполните перегрузку
//+ (для увеличения зарплаты на указанное количество),
//– (для уменьшения зарплаты на указанное количество),
//== и != (проверка на равенство/не равенство зарплат работников),
//< и > (проверка на меньшее или большее количество зарплат работников),
//Используйте механизм свойств полей класса.

using C_Charp_Pro_HomeWork4_1;

public static class Program
{
    public static void Main()
    {
        Employee employee1 = new Employee("Vasya", 150);
        Employee employee2 = new Employee("Petya", 170);

        Console.WriteLine($"Начальная зарплата {employee1.FullName}: ${employee1.Salary}");
        Console.WriteLine($"Начальная зарплата {employee2.FullName}: ${employee2.Salary}");

        Console.WriteLine();

        employee1 = employee1 + 30;
        Console.WriteLine($"После увеличения зарплаты {employee1.FullName}: ${employee1.Salary}");

        employee1 = employee1 - 20;
        Console.WriteLine($"После уменьшения зарплаты {employee1.FullName}: ${employee1.Salary}");

        Console.WriteLine();

        employee2 = employee2 - 10;
        Console.WriteLine($"После уменьшения зарплаты {employee2.FullName}: ${employee2.Salary}");

        Console.WriteLine();

        bool result = employee1 == employee2;
        Console.WriteLine($"Равны ли зарплаты работника {employee1.FullName} и {employee2.FullName}? - {result}");
        result = employee1 != employee2;
        Console.WriteLine($"Не равны ли зарплаты работника {employee1.FullName} и {employee2.FullName}? - {result}");

        result = employee1 > employee2;
        Console.WriteLine($"Зарплата {employee1.FullName} больше чем зарплата {employee2.FullName}? - {result}");
        result = employee1 < employee2;
        Console.WriteLine($"Зарплата {employee1.FullName} меньше чем зарплата {employee2.FullName}? - {result}");

        Console.WriteLine();

        Console.WriteLine($"Зарплата {employee1.FullName}: ${employee1.Salary}");
        Console.WriteLine($"Зарплата {employee2.FullName}: ${employee2.Salary}");
    }
}
