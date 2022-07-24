using System;
using System.IO;

namespace modul6
{
    internal class Program
    {
        static void ReadFileEmployee()
        {
            FileInfo info = new FileInfo(@"Employees.txt");
            if (!info.Exists)
            {
                Console.Write("Файла не существует");
            }

            else if (info.Exists)
            {
                string employeesFile = File.ReadAllText(@"Employees.txt");
                string[] employeesMass = employeesFile.Split('#');
                foreach (string employee in employeesMass) Console.Write($"{employee} ");
            }            
        }
        static void WriteFileEmployee()
        {
            while (true)
            {
                Console.Write("Введите ID: ");
                string ID = Console.ReadLine();

                string date = DateTime.Now.ToString("dd.MM.yyyy hh:mm");

                Console.Write("Введите ФИО: ");
                string name = Console.ReadLine();

                Console.Write("Введите возраст: ");
                string age = Console.ReadLine();

                Console.Write("Введите рост: ");
                string growth = Console.ReadLine();

                Console.Write("Введите дату рождения: ");
                string dateOfBirth = Console.ReadLine();

                Console.Write("Введите место рождения: ");
                string placeOfBirth = Console.ReadLine();

                string employeesLine = $"{ID}#{date}#{name}#{age}#{growth}#{dateOfBirth}#{placeOfBirth}";

                FileInfo info = new FileInfo(@"Employees.txt");
                if (!info.Exists)
                {
                    File.WriteAllText(@"Employees.txt", employeesLine);
                }

                else if (info.Exists)
                {
                    File.AppendAllText(@"Employees.txt", $"\n{employeesLine}");
                }
                Console.WriteLine("\nВведите данные следующего сотрудника:");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("СПРАВОЧНИК СОТРУДНИКОВ\nВыберите опцию\n1 — вывести данные на экран, 2 — заполнить данные: ");
            string option = Console.ReadLine();

            if(option == "1")
            {
                ReadFileEmployee();
            }
            else if(option == "2")
            {
                WriteFileEmployee();
            }
            else
            {
                Console.WriteLine("Неверная опция");
            }

            Console.ReadKey();
        }
    }
}
