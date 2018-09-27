using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomaineModel;
using Infrastructure;

namespace ApplicationLogic
{
    public class PKApp
    {
        public void TheApp()
        {
            PKDBUtil PKUtil = new PKDBUtil();
            //Person tempPerson = new Person("", "", "", "", null);

            City c1 = new City("Aarhus", "8200", "Denmark");
            PKUtil.AddCityDB(ref c1);

            Address a1 = new Address("Goeteborg Alle", "12", c1.CityID);
            PKUtil.AddAddressDB(ref a1);

            /*
            Address a1 = new Address("Goeteborg Alle", "12", c1);
            Person p1 = new Person("Oliver", "Monberg", "Danish", "Male", a1);
            PKUtil.AddPersonDB(ref p1);

            Person p2 = new Person("Oliver", "Monberg", "", "", null);
            PKUtil.GetPersonByName(ref p2);

            Console.WriteLine($"Person1 - Name: {p2.FirstName} {p2.LastName}." +
                              $"Nationality: {p2.Nationality}. Gender: {p2.Gender}");
            */

            Console.ReadKey();
        }
    }
}
