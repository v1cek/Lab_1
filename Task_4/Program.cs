using System;

namespace Lab_1
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private readonly DateTime registrationDate; 

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            registrationDate = DateTime.Now; 
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Логін: " + Login);
            Console.WriteLine("Ім'я: " + FirstName);
            Console.WriteLine("Прізвище: " + LastName);
            Console.WriteLine("Вік: " + Age);
            Console.WriteLine("Дата заповнення анкети: " + registrationDate.ToShortDateString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.Write("Введіть ім'я: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть прізвище: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть вік: ");
            int age = Convert.ToInt32(Console.ReadLine());

            User user = new User(login, firstName, lastName, age);

            user.DisplayInfo();
        }
    }
}
