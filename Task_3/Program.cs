using System;

class Employee
{
    // Поля класу
    public string LastName;
    public string FirstName;
    public string Position;
    public int Experience;
    public double Salary;

    // Конструктор
    public Employee(string lastName, string firstName)
    {
        LastName = lastName;
        FirstName = firstName;
    }

    // Метод для розрахунку окладу
    public void CalculateSalary()
    {
        double baseSalary = 0;

        // Визначаємо базовий оклад залежно від посади
        if (Position == "Продавець-консультант")
        {
            baseSalary = 50000;
        }
        else if (Position == "Керівник")
        {
            baseSalary = 60000;
        }
        else if (Position == "Менеджер")
        {
            baseSalary = 55000;
        }
        else
        {
            baseSalary = 40000; // для інших посад
        }

        // Додаємо надбавку за стаж
        Salary = baseSalary + (Experience * 2000);
    }

    // Метод для розрахунку податку
    public double CalculateTax()
    {
        return Salary * 0.15; // 15% податок
    }

    // Метод для виведення інформації
    public void DisplayInfo()
    {
        Console.WriteLine("Прізвище: " + LastName);
        Console.WriteLine("Ім'я: " + FirstName);
        Console.WriteLine("Посада: " + Position);
        Console.WriteLine("Оклад: " + Salary);
        Console.WriteLine("Податковий збір: " + CalculateTax());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Введення даних співробітника
        Console.Write("Введіть прізвище співробітника: ");
        string lastName = Console.ReadLine();

        Console.Write("Введіть ім'я співробітника: ");
        string firstName = Console.ReadLine();

        Employee employee = new Employee(lastName, firstName);

        Console.Write("Введіть посаду співробітника: ");
        employee.Position = Console.ReadLine();

        Console.Write("Введіть стаж роботи (в роках): ");
        employee.Experience = Convert.ToInt32(Console.ReadLine());

        // Розрахунок окладу
        employee.CalculateSalary();

        // Виведення інформації про співробітника
        employee.DisplayInfo();
    }
}
