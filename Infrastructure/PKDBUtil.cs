using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomaineModel;

namespace Infrastructure
{
    public class PKDBUtil
    {
        private Person currentPerson;
        /// <summary>
        /// Constructor may be use to initialize the connection string and likely setup things 
        /// </summary>
        public PKDBUtil()
        {
            //currentPerson = new Person("", "", "", "", null);
        }

        private SqlConnection OpenConnection
        {
            get
            {
                var con = new SqlConnection(@"Data Source=10.83.16.131;Initial Catalog=E18I4DABau554208;User ID=E18I4DABau554208;Password=E18I4DABau554208;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                return con;
            }
        }

        public void AddCityDB(ref City c)
        {
            string insertStringParam1 = "SELECT COUNT(*) FROM[City] WHERE (CityName = @CityName and PostalCode = @PostalCode and Country = @Country)";

            SqlCommand check_if_city_exists = new SqlCommand(insertStringParam1, OpenConnection);
            check_if_city_exists.Parameters.AddWithValue("@CityName", c.CityName);
            check_if_city_exists.Parameters.AddWithValue("@PostalCode", c.PostalCode);
            check_if_city_exists.Parameters.AddWithValue("@Country", c.Country);

            int UserExist = (int)check_if_city_exists.ExecuteScalar();

            if (UserExist > 0)
            {
                //Username exist
            }
            else
            {
                //Username doesn't exist.
                string insertStringParam = @"INSERT INTO [City] (PostalCode, Country, CityName)
                                                OUTPUT INSERTED.CityID
                                                VALUES (@PostalCode, @Country, @CityName)";

                using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
                {
                    cmd.Parameters.AddWithValue("@PostalCode", c.PostalCode);
                    cmd.Parameters.AddWithValue("@Country", c.Country);
                    cmd.Parameters.AddWithValue("@CityName", c.CityName);
                    c.CityID = (long) cmd.ExecuteScalar();
                }
            }
        }

        public void DeleteCityDB(ref City c)
        {
            string deleteString = @"DELETE FROM City WHERE (CityID = @CityID)";

            using (SqlCommand cmd = new SqlCommand(deleteString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@CityID", c.CityID);

                cmd.ExecuteNonQuery();
            }
        }

        public void GetCityIDByCityNameAndPostalCodeAndCountry(ref City c)
        {
            string sqlcmd = @"SELECT  TOP 1 * FROM City WHERE (CityName = @CityName) AND (PostalCode = @PostalCode) AND (Country = @Country)";
            using (var cmd = new SqlCommand(sqlcmd, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@CityName", c.CityName);
                cmd.Parameters.AddWithValue("@PostalCode", c.PostalCode);
                cmd.Parameters.AddWithValue("@Country", c.Country);
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    c.CityID = (long) rdr["CityID"];
                }
            }
        }

        public void GetCityObjectByID(ref City c)
        {
            string sqlcmd = @"SELECT  TOP 1 * FROM City WHERE (CityID = @CityID)";
            using (var cmd = new SqlCommand(sqlcmd, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@CityID", c.CityID);
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    c.CityName = (string) rdr["CityName"];
                    c.CityID = (long)rdr["CityID"];
                    c.Country = (string)rdr["Country"];
                    c.PostalCode = (string) rdr["PostalCode"];
                }
            }
        }

        public void AddAddressDB(ref Address a)
        {
            string insertStringParam1 = "SELECT COUNT(*) FROM[Address] WHERE (StreetName = @StreetName and StreetNumber = @StreetNumber and CityID = @CityID)";

            SqlCommand check_if_city_exists = new SqlCommand(insertStringParam1, OpenConnection);
            check_if_city_exists.Parameters.AddWithValue("@StreetName", a.StreetName);
            check_if_city_exists.Parameters.AddWithValue("@StreetNumber", a.StreetNumber);
            check_if_city_exists.Parameters.AddWithValue("@CityID", a.CityID);

            int UserExist = (int)check_if_city_exists.ExecuteScalar();

            if (UserExist > 0)
            {
                //Username exist
            }
            else
            {
                string insertStringParam = @"INSERT INTO [Address] (StreetName, StreetNumber, CityID)
                                            OUTPUT INSERTED.AddressID
                                            VALUES (@StreetName, @StreetNumber, @CityID)";

                using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
                {
                    cmd.Parameters.AddWithValue("@StreetName", a.StreetName);
                    cmd.Parameters.AddWithValue("@StreetNumber", a.StreetNumber);
                    cmd.Parameters.AddWithValue("@CityID", a.CityID);
                    a.AddressID = (long) cmd.ExecuteScalar();
                }
            }
        }

        public void GetAddressIDByStreetNameAndStreetNumberAndCityID(ref Address c)
        {
            string sqlcmd = @"SELECT  TOP 1 * FROM Address WHERE (StreetName = @StreetName) AND (StreetNumber = @StreetNumber) AND (CityID = @CityID)";
            using (var cmd = new SqlCommand(sqlcmd, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@StreetName", c.StreetName);
                cmd.Parameters.AddWithValue("@StreetNumber", c.StreetNumber);
                cmd.Parameters.AddWithValue("@CityID", c.CityID);
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    c.AddressID = (long)rdr["AddressID"];
                }
            }
        }

        public void UpdateAddressDB(ref Address a)
        {
            string updateString =
                @"UPDATE Address
                  SET StreetName = @StreetName, StreetNumber = @StreetNumber, CityID = @CityID
                  WHERE AddressID = @AddressID";

            using (SqlCommand cmd = new SqlCommand(updateString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@StreetName", a.StreetName);
                cmd.Parameters.AddWithValue("@StreetNumber", a.StreetNumber);
                cmd.Parameters.AddWithValue("@CityID", a.CityID);
                cmd.Parameters.AddWithValue("@AddressID", a.AddressID);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddPersonDB(ref Person p)
        {
            string insertStringParam1 = "SELECT COUNT(*) FROM[Person] WHERE (FirstName = @FirstName and LastName = @LastName and Gender = " +
                                        "@Gender and Nationality = @Nationality and AddressID = @AddressID)";

            SqlCommand check_if_city_exists = new SqlCommand(insertStringParam1, OpenConnection);
            check_if_city_exists.Parameters.AddWithValue("@FirstName", p.FirstName);
            check_if_city_exists.Parameters.AddWithValue("@LastName", p.LastName);
            check_if_city_exists.Parameters.AddWithValue("@Gender", p.Gender);
            check_if_city_exists.Parameters.AddWithValue("@Nationality", p.Nationality);
            check_if_city_exists.Parameters.AddWithValue("@AddressID", p.AddressID);

            int UserExist = (int)check_if_city_exists.ExecuteScalar();

            if (UserExist > 0)
            {
                //Username exist
            }
            else
            {
                string insertStringParam = @"INSERT INTO [Person] (FirstName, LastName, Nationality, Gender, AddressID)
                                                OUTPUT INSERTED.PersonID
                                                VALUES (@FirstName, @LastName, @Nationality, @Gender, @AddressID)";

                using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
                {
                    //cmd.Parameters.AddWithValue("@PersonID", 1);
                    cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", p.LastName);
                    cmd.Parameters.AddWithValue("@Nationality", p.Nationality);
                    cmd.Parameters.AddWithValue("@Gender", p.Gender);
                    cmd.Parameters.AddWithValue("@AddressID", p.AddressID);
                    p.PersonID = (long)cmd.ExecuteScalar();
                    //p.PrimaryAddress = (Address)cmd.ExecuteScalar();
                }  
            }
        }

        public void GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref Person c)
        {
            string sqlcmd = @"SELECT  TOP 1 * FROM Person WHERE (FirstName = @FirstName) AND (LastName = @LastName) AND (Nationality = @Nationality) AND (Gender = @Gender) AND (AddressID = @AddressID)";
            using (var cmd = new SqlCommand(sqlcmd, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Nationality", c.Nationality);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@AddressID", c.AddressID);

                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    c.PersonID = (long)rdr["PersonID"];
                }
            }
        }

        public void UpdatePersonDB(ref Person p)
        {
            string updateString =
                @"UPDATE Person
                  SET FirstName = @FirstName, LastName = @LastName,
                        Nationality = @Nationality, Gender = @Gender, AddressID = @AddressID
                  WHERE PersonID = @PersonID";

            using (SqlCommand cmd = new SqlCommand(updateString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
                cmd.Parameters.AddWithValue("@LastName", p.LastName);
                cmd.Parameters.AddWithValue("@Nationality", p.Nationality);
                cmd.Parameters.AddWithValue("@Gender", p.Gender);
                cmd.Parameters.AddWithValue("@AddressID", p.AddressID);
                cmd.Parameters.AddWithValue("@PersonID", p.PersonID);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void DeletePersonDB(ref Person c)
        {
            string deleteString = @"DELETE FROM Person WHERE (PersonID = @PersonID)";

            using (SqlCommand cmd = new SqlCommand(deleteString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@PersonID", c.PersonID);

                cmd.ExecuteNonQuery();
            }
        }

        public void AddAlternativeAddressDB(ref AlternativeAddress p)
        {
            string insertStringParam1 = "SELECT COUNT(*) FROM[AlternativeAddress] WHERE (PersonID = @PersonID and AddressID = @AddressID and Type = @Type)";

            SqlCommand check_if_city_exists = new SqlCommand(insertStringParam1, OpenConnection);
            check_if_city_exists.Parameters.AddWithValue("@PersonID", p.PersonID);
            check_if_city_exists.Parameters.AddWithValue("@AddressID", p.AddressID);
            check_if_city_exists.Parameters.AddWithValue("@Type", p.Type);

            int UserExist = (int)check_if_city_exists.ExecuteScalar();

            if (UserExist > 0)
            {
                //Username exist
            }
            else
            {
                string insertStringParam = @"INSERT INTO [AlternativeAddress] (PersonID, AddressID, Type)
                                                OUTPUT INSERTED.PersonID
                                                VALUES (@PersonID, @AddressID, @Type)";

                using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
                {
                    cmd.Parameters.AddWithValue("@PersonID", p.PersonID);
                    cmd.Parameters.AddWithValue("@AddressID", p.AddressID);
                    cmd.Parameters.AddWithValue("@Type", p.Type);
                    p.AlternativeAddressID = (long)cmd.ExecuteScalar();
                }
            }
        }

        public void GetAlternativeAddressIDByPersonAndAddressAndType(ref AlternativeAddress c)
        {
            string sqlcmd = @"SELECT  TOP 1 * FROM AlternativeAddress WHERE (PersonID = @PersonID) AND (AddressID = @AddressID) AND (Type = @Type)";
            using (var cmd = new SqlCommand(sqlcmd, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@PersonID", c.PersonID);
                cmd.Parameters.AddWithValue("@AddressID", c.AddressID);
                cmd.Parameters.AddWithValue("@Type", c.Type);

                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    c.AlternativeAddressID = (long)rdr["AlternativeAddressID"];
                }
            }
        }

        public void UpdateAlternativeAddressDB(ref AlternativeAddress p)
        {
            string updateString =
                @"UPDATE AlternativeAddress
                  SET PersonID = @PersonID, AddressID = @AddressID, Type = @Type
                  WHERE AlternativeAddressID = @AlternativeAddressID";

            using (SqlCommand cmd = new SqlCommand(updateString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@Type", p.Type);
                cmd.Parameters.AddWithValue("@AddressID", p.AddressID);
                cmd.Parameters.AddWithValue("@PersonID", p.PersonID);
                cmd.Parameters.AddWithValue("@AlternativeAddressID", p.AlternativeAddressID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAlternativeAddressDB(ref AlternativeAddress c)
        {
            string deleteString = @"DELETE FROM AlternativeAddress WHERE (AlternativeAddressID = @AlternativeAddressID)";

            using (SqlCommand cmd = new SqlCommand(deleteString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@AlternativeAddressID", c.AlternativeAddressID);

                cmd.ExecuteNonQuery();
            }
        }

        public void AddNoteDB(ref Note c)
        {
            string insertStringParam1 = "SELECT COUNT(*) FROM[Note] WHERE (NoteText = @NoteText and PersonID = @PersonID)";

            SqlCommand check_if_city_exists = new SqlCommand(insertStringParam1, OpenConnection);
            check_if_city_exists.Parameters.AddWithValue("@NoteText", c.NoteText);
            check_if_city_exists.Parameters.AddWithValue("@PersonID", c.PersonID);

            int UserExist = (int)check_if_city_exists.ExecuteScalar();

            if (UserExist > 0)
            {
                //Username exist
            }
            else
            {
                //Username doesn't exist.
                string insertStringParam = @"INSERT INTO [Note] (NoteText, PersonID)
                                                OUTPUT INSERTED.NoteID
                                                VALUES (@NoteText, @PersonID)";

                using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
                {
                    cmd.Parameters.AddWithValue("@NoteText", c.NoteText);
                    cmd.Parameters.AddWithValue("@PersonID", c.PersonID);
                    c.NoteID = (long)cmd.ExecuteScalar();
                }
            }
        }

        public void GetNoteIDByNoteTextAndPersonID(ref Note c)
        {
            string sqlcmd = @"SELECT  TOP 1 * FROM Note WHERE (NoteText = @NoteText) AND (PersonID = @PersonID)";
            using (var cmd = new SqlCommand(sqlcmd, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@NoteText", c.NoteText);
                cmd.Parameters.AddWithValue("@PersonID", c.PersonID);
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    c.NoteID = (long)rdr["NoteID"];
                }
            }
        }

        public void UpdateNoteDB(ref Note a)
        {
            string updateString =
                @"UPDATE Note
                  SET NoteText = @NoteText WHERE NoteID = @NoteID";

            using (SqlCommand cmd = new SqlCommand(updateString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@NoteText", a.NoteText);
                cmd.Parameters.AddWithValue("@NoteID", a.NoteID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteNoteDB(ref Note c)
        {
            string deleteString = @"DELETE FROM Note WHERE (NoteID = @NoteID)";

            using (SqlCommand cmd = new SqlCommand(deleteString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@NoteID", c.NoteID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}