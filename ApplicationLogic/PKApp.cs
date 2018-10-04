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
            //Person tempPerson = new Person("Oliver", "Monberg", "", "", null);

            
            City c1 = new City("Aarhuss", "8200", "Denmark");
            PKUtil.AddCityDB(ref c1);
           
            //PKUtil.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);
            //PKUtil.GetCityObjectByID(ref c1);

            Address a1 = new Address("Goeteborg Alles", "12", c1);
            PKUtil.AddAddressDB(ref a1);
           
            Person p1 = new Person("Olivers", "Monberg", "Danish", "Male", a1);
            PKUtil.AddPersonDB(ref p1);
            
            /*
            PKUtil.GetPersonByName(ref tempPerson);

            long l = PKUtil.GetCityIDByName("Aarhus");

            Console.WriteLine($"CityID: {l}");

            Console.WriteLine($"Person1 - Name: {tempPerson.FirstName} {tempPerson.LastName}." +
                              $"Nationality: {tempPerson.Nationality}. Gender: {tempPerson.Gender}. PersonID: {tempPerson.PersonID}");
            */
            Console.ReadKey();
        }
    }
}
