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

        static void Main()
        {
            Console.Write("Enter Pat for Batabase: ");
            Path = Console.ReadLine();
            ServiceClient service = new ServiceClient(Path);
            Client client = new Client();
            client.INN = "030318500265";
            client.Email = "www.asemush@gmail.com";
            client.FirstName = "Sattar";
            client.MiddleName = "Beknur";
            client.LastName = "Bekzhanuli";
            client.BirstDay = new DateTime(2003, 03, 03);
            client.CreateDate = DateTime.Now;
            client.Adress = new Adress()
            {
                Country = "Kazakhstan",
                City = "Almaty",
                House = "Taugul 2",
                Region = "Orbita",
                Street = "Riskulbekova"
            };

            service.Registration(client);
        }
    }
}
