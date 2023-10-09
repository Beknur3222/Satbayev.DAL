using Satbayev.BLL;
using Satbayev.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.ConsoleApp
{
    internal class Program
    {
        public static string Path = "";

        static void Main(string[] args)
        {
            Console.Write("Enter Pat for Batabase: ");
            Path = Console.ReadLine();
            ServiceClient service = new ServiceClient(Path);
            Console.WriteLine("(1 - Авторизация) ");
            Console.WriteLine("(2 - Регистрация) ");
            string Question = Console.ReadLine();
            if(Question == "1")
            {
                Console.WriteLine("Введите ваш логин");
                string login = Console.ReadLine();

                Console.WriteLine("Введите ваш пароль:");
                string password = Console.ReadLine();

                Client cleint = service.Auth(login, password);

                if(cleint == null)
                {
                    Console.WriteLine("Ваш логин или пароль неправелный!!!");
                }
                else
                {
                    Console.WriteLine("Привет" + cleint.FirstName);
                }
            }
            else if(Question == "2")
            {
                Client client = new Client();

                Console.Write("Введите ИИН:");
                client.INN = Console.ReadLine();

                Console.Write("Введите Почту:");
                client.Email = Console.ReadLine();

                Console.Write("Введите Имя:");
                client.FirstName = Console.ReadLine();

                Console.Write("Введите Фамилия:");
                client.MiddleName = Console.ReadLine();

                Console.Write("Введите Очество:");
                client.LastName = Console.ReadLine();

                Console.Write("Введите Дату рождения:");
                client.BirstDay = DateTime.Parse(Console.ReadLine());
                
                client.CreateDate = DateTime.Now;

                Console.Write("Введите Адрес(Страна, Город, Дом, Регион, Улица, код региона):");
                client.Adress = new Adress()
                {
                    Country = Console.ReadLine(),
                    City = Console.ReadLine(),
                    House = Console.ReadLine(),
                    Region = Console.ReadLine(),
                    Street = Console.ReadLine(),
                    PostalCode = Console.ReadLine()
                };

                service.Registration(client);
            }
        }
    }
}
