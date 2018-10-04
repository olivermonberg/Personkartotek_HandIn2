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

            
            City c1 = new City("Aarhus", "8200", "Denmark");

            //PKUtil.AddCityDB(ref c1);
            //
            //City c2 = new City("Aarhus", "8200", "Denmark");
            //PKUtil.AddCityDB(ref c2);
            
            PKUtil.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);
            //PKUtil.DeleteCityDB(ref c1);

            //PKUtil.GetCityObjectByID(ref c1);
            
            Address a1 = new Address("Goeteborg Alle", "12", c1);
            //PKUtil.AddAddressDB(ref a1);

            
            PKUtil.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

            Person p1 = new Person("Briam", "Monberg2", "Danish2", "Male2", a1);
            //PKUtil.AddPersonDB(ref p1);

            PKUtil.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);

            //p1.FirstName = "Briam";

            //PKUtil.UpdatePersonDB(ref p1);

            PKUtil.DeletePersonDB(ref p1);

            /*Address a2 = new Address("Johannesgade", "10",c1);
            a2.AddressID = a1.AddressID;

            PKUtil.UpdateAddressDB(ref a2);

            Console.ReadKey();
            */


            //Person p1 = new Person("Olivers", "Monberg", "Danish", "Male", a1);
            //PKUtil.AddPersonDB(ref p1);


            //PKUtil.UpdatePersonDB();

            /*
            PKUtil.GetPersonByName(ref tempPerson);

            long l = PKUtil.GetCityIDByName("Aarhus");

            Console.WriteLine($"CityID: {l}");

            Console.WriteLine($"Person1 - Name: {tempPerson.FirstName} {tempPerson.LastName}." +
                              $"Nationality: {tempPerson.Nationality}. Gender: {tempPerson.Gender}. PersonID: {tempPerson.PersonID}");
            */
            //Console.ReadKey();
        }
    }
}
