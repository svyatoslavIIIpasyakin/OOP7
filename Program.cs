using System;
using System.Collections.Generic;

// Базовый класс - компьютер
class Computer
{
    public string Brand { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Brand: {Brand}, Price: {Price}";
    }
}

// Производные классы - ноутбук и смартфон
class Laptop : Computer
{
    public string Processor { get; set; }

    public void LaptopSpecificMethod()
    {
        // Операции, специфичные для ноутбука
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Price: {Price}, Processor: {Processor}";
    }
}

class Smartphone : Computer
{
    public string OS { get; set; }

    public void SmartphoneSpecificMethod()
    {
        // Операции, специфичные для смартфона
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Price: {Price}, OS: {OS}";
    }
}

// Класс РемонтСервис
class RepairService
{
    private List<Computer> computers = new List<Computer>();

    public void AddComputer(Computer computer)
    {
        computers.Add(computer);
    }

    public int CountLaptops()
    {
        return computers.FindAll(c => c is Laptop).Count;
    }

    public int CountSmartphones()
    {
        return computers.FindAll(c => c is Smartphone).Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        RepairService repairService = new RepairService();

        // Создание экземпляров базового класса
        Computer computer1 = new Computer { Brand = "Generic", Price = 500 };
        Computer computer2 = new Computer { Brand = "Another", Price = 700 };

        // Создание экземпляров производных классов
        Laptop laptop1 = new Laptop { Brand = "Lenovo", Price = 1000, Processor = "Intel Core i5" };
        Laptop laptop2 = new Laptop { Brand = "Dell", Price = 1200, Processor = "AMD Ryzen 7" };

        Smartphone phone1 = new Smartphone { Brand = "Samsung", Price = 800, OS = "Android" };
        Smartphone phone2 = new Smartphone { Brand = "Apple", Price = 1200, OS = "iOS" };

        // Вызов методов на базовом и производных классах
        Console.WriteLine(computer1.ToString());
        Console.WriteLine(computer2.ToString());
        Console.WriteLine(laptop1.ToString());
        Console.WriteLine(laptop2.ToString());
        Console.WriteLine(phone1.ToString());
        Console.WriteLine(phone2.ToString());

        // Добавление экземпляров в RepairService
        repairService.AddComputer(computer1);
        repairService.AddComputer(computer2);
        repairService.AddComputer(laptop1);
        repairService.AddComputer(laptop2);
        repairService.AddComputer(phone1);
        repairService.AddComputer(phone2);

        // Получение количества отдельно по каждому типу
        int laptopCount = repairService.CountLaptops();
        int phoneCount = repairService.CountSmartphones();

        Console.WriteLine($"Laptop count: {laptopCount}");
        Console.WriteLine($"Smartphone count: {phoneCount}");
    }
}
