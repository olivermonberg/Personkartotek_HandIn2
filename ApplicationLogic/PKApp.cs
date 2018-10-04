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


            City c2 = new City("Aarhus", "8200", "Denmark");
            PKUtil.GetCityIDByCityNameAndPostalCodeAndCountry(ref c2);

            Address a2 = new Address("Goeteborg Alle", "12", c2);
            PKUtil.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a2);

            Person p1 = new Person("Leif", "Larsen", "Vietnam", "Male", a2);
            PKUtil.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);


            City c1 = new City("Grenaa", "1234", "Denmark");
            //PKUtil.AddCityDB(ref c1);

            PKUtil.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

            Address a1 = new Address("Torskevej", "10", c1);
            //PKUtil.AddAddressDB(ref a1);
            PKUtil.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

            AlternativeAddress aa1 = new AlternativeAddress(p1, a1, "Sommerhus");
            //PKUtil.AddAlternativeAddressDB(ref aa1);

            PKUtil.GetAlternativeAddressIDByPersonAndAddressAndType(ref aa1);

            City c3 = new City("Silkeborg", "4321", "Denmark");
            //PKUtil.AddCityDB(ref c3);

            PKUtil.GetCityIDByCityNameAndPostalCodeAndCountry(ref c3);

            Address a3 = new Address("Filetvej", "20", c3);
            //PKUtil.AddAddressDB(ref a3);

            PKUtil.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a3);



            aa1.AddressID = a3.AddressID;
            PKUtil.UpdateAlternativeAddressDB(ref aa1);



            PKUtil.DeleteAlternativeAddressDB(ref aa1);

            //City c2 = new City("Aarhus", "8200", "Denmark");
            //PKUtil.GetCityIDByCityNameAndPostalCodeAndCountry(ref c2);
            //Address a2 = new Address("Goeteborg Alle", "12", c2);
            //PKUtil.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a2);
            //
            //p1.AddressID = a2.AddressID;
            //PKUtil.UpdatePersonDB(ref p1);

            //Console.ReadKey();
        }
    }
}
