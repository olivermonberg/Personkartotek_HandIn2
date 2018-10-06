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

            //--------------- NOTE --------------
            
            Note n2 = new Note("Dette er en note.");
            n2.PersonID = p2.PersonID;

            //util.AddNoteDB(ref n2);

            //util.GetNoteIDByNoteTextAndPersonID(ref n2);
            //n2.NoteText = "Opdateret notetekst";
            //util.UpdateNoteDB(ref n2);

            n2.NoteText = "Opdateret notetekst";
            util.GetNoteIDByNoteTextAndPersonID(ref n2);
            util.DeleteNoteDB(ref n2);
            


            //---------- EMAIL -------------
            /*
            Email e2 = new Email("olivermonberg@gmail.com");
            e2.PersonID = p2.PersonID;

            util.AddEmailDB(ref e2);

            //util.GetEmailIDByEmailAddressAndPersonID(ref e2);
            //e2.EmailAddress = "olivermonberg@hotmail.com";
            //util.UpdateEmailDB(ref e2);

            //e2.EmailAddress = "olivermonberg@hotmail.com";
            //util.GetEmailIDByEmailAddressAndPersonID(ref e2);
            //util.DeleteEmailDB(ref e2);
            */


            //----------- Phone ----------
            /*
            PhoneCarrier pc1 = new PhoneCarrier("Telia");

            util.AddPhoneCarrierDB(ref pc1);

            //util.GetPhoneCarrierIDByCompanyName(ref pc1);
            //PhoneNumber pn1 = new PhoneNumber("20203045", pc1);
            //pn1.PersonID = p2.PersonID;
            //util.AddPhoneNumberDB(ref pn1);

            //util.GetPhoneNumberIDByNum(ref pn1);
            //pn1.Num = "40402121";
            //util.UpdatePhoneNumberDB(ref pn1);

            //util.GetPhoneNumberIDByNum(ref pn1);
            //util.DeletePhoneNumberDB(ref pn1);
            */
        }
    }
}
