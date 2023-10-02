using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL
{
    public class Client
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ShortName
        {
            get
            {
                if (string.IsNullOrEmpty(LastName))//Sattar B.
                {
                    return string.Format("{0} {1}.",
                        FirstName, MiddleName[0]);
                }
                else//Sattar B.B.
                {
                    return string.Format("{0} {1}. {2}.",
                        FirstName, MiddleName[0], LastName[0]);
                }

            }
        }
        public string FullName { get { return FullName; } }
        public DateTime BirstDay { get; set; }
        public int GetAge
        {
            get
            {
                return DateTime.Now.Year - BirstDay.Year;
            }
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string INN { get; set; }
        public Adress Adress { get; set; }

    }


}
