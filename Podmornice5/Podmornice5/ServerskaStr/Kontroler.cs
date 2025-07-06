using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerskaStr
{
    public class Kontroler
    {
        private static Kontroler instance;
        private List<Admin>admini = new List<Admin>();  
        public static Kontroler Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Kontroler();
                }
                return instance;
            }
            
        }

        public Kontroler()
        {
            Admin a1 = new Admin()
            {
                Ime = "Pera",
                Prezime = "Peric",
                Username = "pera@gmail.com",
                Password = "12345"
            };
            admini.Add(a1);
            Admin a2 = new Admin()
            {
                Ime = "Mara",
                Prezime = "Maric",
                Username = "mara@gmail.com",
                Password = "6789"
            };
            admini.Add(a2);

        }

        internal bool Login(Admin ulogovaniAdmin)
        {
           foreach(Admin admin in admini)
            {
                if(admin.Username.Equals(ulogovaniAdmin.Username) && admin.Password.Equals(ulogovaniAdmin.Password))
                {
                    ulogovaniAdmin.Ime=admin.Ime;
                    ulogovaniAdmin.Prezime=admin.Prezime;
                    return true;
                }

            }
           return false;
        }
    }
}
