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
            PKDBUtil util = new PKDBUtil();
            

            City c2 = new City("Aarhus", "8200", "Denmark");
            util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c2);

            Address a2 = new Address("Goeteborg Alle", "12", c2);
            util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a2);

            Person p2 = new Person("Oliver", "Monberg", "Danish", "Male", a2);
            util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p2);

            Note n2 = new Note("Dette er en note.");
            n2.PersonID = p2.PersonID;

            //util.AddNoteDB(ref n2);

            //util.GetNoteIDByNoteTextAndPersonID(ref n2);
            //n2.NoteText = "Opdateret notetekst";
            //util.UpdateNoteDB(ref n2);

            n2.NoteText = "Opdateret notetekst";
            util.GetNoteIDByNoteTextAndPersonID(ref n2);
            util.DeleteNoteDB(ref n2);
        }
    }
}
