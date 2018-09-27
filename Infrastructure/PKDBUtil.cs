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
            currentPerson = new Person("", "", "", "", null);
        }

        private SqlConnection OpenConnection
        {
            get
            {
                //var con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=CraftManDB;Integrated Security=True");
                var con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Personkartotek_HandIn2;Integrated Security=True;Pooling=False;Connect Timeout=30");
                con.Open();
                return con;
            }
        }

        public void AddCityDB(ref City c)
        {
            string insertStringParam = @"INSERT INTO [City] (PostalCode, Country, CityName)
                                            OUTPUT INSERTED.CityID
                                            VALUES (@PostalCode, @Country, @CityName)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
            {
                //cmd.Parameters.AddWithValue("@PersonID", 1);
                cmd.Parameters.AddWithValue("@PostalCode", c.PostalCode);
                cmd.Parameters.AddWithValue("@Country", c.Country);
                cmd.Parameters.AddWithValue("@CityName", c.CityName);
                c.CityID = (long) cmd.ExecuteScalar();
                //p.PrimaryAddress = (Address)cmd.ExecuteScalar();
            }
        }

        public void AddAddressDB(ref Address c)
        {
            string insertStringParam = @"INSERT INTO [Address] (StreetName, StreetNumber, CityID)
                                            OUTPUT INSERTED.AddressID
                                            VALUES (@StreetName, @StreetNumber, @CityID)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
            {
                //cmd.Parameters.AddWithValue("@PersonID", 1);
                cmd.Parameters.AddWithValue("@StreetName", c.StreetName);
                cmd.Parameters.AddWithValue("@StreetNumber", c.StreetNumber);
                cmd.Parameters.AddWithValue("@CityID", c.CityID);
                c.AddressID = (long)cmd.ExecuteScalar();
                //p.PrimaryAddress = (Address)cmd.ExecuteScalar();
            }
        }

        public void AddPersonDB(ref Person p)
        {
            string insertStringParam = @"INSERT INTO [Person] (FirstName, LastName, Nationality, Gender, PrimaryAddress)
                                            OUTPUT INSERTED.PersonID
                                            VALUES (@FirstName, @LastName, @Nationality, @Gender, @PrimaryAddress)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
            {
                //cmd.Parameters.AddWithValue("@PersonID", 1);
                cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
                cmd.Parameters.AddWithValue("@LastName", p.LastName);
                cmd.Parameters.AddWithValue("@Nationality", p.Nationality);
                cmd.Parameters.AddWithValue("@Gender", p.Gender);
                cmd.Parameters.AddWithValue("@PrimaryAddress", null);
               // p.PersonID = (long) cmd.ExecuteScalar();
                //p.PrimaryAddress = (Address)cmd.ExecuteScalar();
            }
        }

        public void UpdatePersonDB(ref Person p)
        {
            string updateString =
                @"UPDATE Person
                  SET FirstName = @FirstName, LastName = @LastName,
                        Nationality = @Nationality, Gender = @Gender, PrimaryAddress = @PrimaryAddress
                  WHERE PersonID = @PersonID";

            using (SqlCommand cmd = new SqlCommand(updateString, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
                cmd.Parameters.AddWithValue("@LastName", p.LastName);
                cmd.Parameters.AddWithValue("@Nationality", p.Nationality);
                cmd.Parameters.AddWithValue("@Gender", p.Gender);
                cmd.Parameters.AddWithValue("@PrimaryAddress", p.PrimaryAddress);

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public void GetPersonByName(ref Person p)
        {
            string sqlcmd = @"SELECT  TOP 1 * FROM Person WHERE (FirstName = @FName) AND (LastName=@LName)";
            using (var cmd = new SqlCommand(sqlcmd, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@FName", p.FirstName);
                cmd.Parameters.AddWithValue("@LName", p.LastName);
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Console.WriteLine("Person found.");
                    currentPerson.PersonID = (int)rdr["PersonID"];
                    currentPerson.FirstName = (string)rdr["FirstName"];
                    currentPerson.FirstName = (string)rdr["LastName"];
                    currentPerson.FirstName = (string)rdr["Nationality"];
                    currentPerson.FirstName = (string)rdr["Gender"];
                    currentPerson.FirstName = (string)rdr["Address"];
                    p = currentPerson;
                }
            }
        }
    }
}
