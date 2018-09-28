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
            currentPerson = new Person("", "", "", "", 0);
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

        public void AddAddressDB(ref Address a)
        {
            string insertStringParam = @"INSERT INTO [Address] (StreetName, StreetNumber, CityID)
                                            OUTPUT INSERTED.AddressID
                                            VALUES (@StreetName, @StreetNumber, @CityID)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
            {
                //cmd.Parameters.AddWithValue("@PersonID", 1);
                cmd.Parameters.AddWithValue("@StreetName", a.StreetName);
                cmd.Parameters.AddWithValue("@StreetNumber", a.StreetNumber);
                cmd.Parameters.AddWithValue("@CityID", a.CityID);
                a.AddressID = (long)cmd.ExecuteScalar();
                //p.PrimaryAddress = (Address)cmd.ExecuteScalar();
            }
        }

        public void AddPersonDB(ref Person p)
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

                var id = (long)cmd.ExecuteNonQuery();
            }
        }

        public long GetCityIDByName(string CityName)
        {
            string sqlcmd = @"SELECT TOP 1 * FROM City WHERE (CityName = @CName)";
            long id = 0;

            using (var cmd = new SqlCommand(sqlcmd, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@CName", CityName);
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Console.WriteLine("CityID found.");
                    id = (long)rdr["CityID"];
                    return id;
                }
                else
                {
                    Console.WriteLine("CityID not found.");
                    return 0;
                }
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
                    currentPerson.PersonID = (long)rdr["PersonID"];
                    currentPerson.FirstName = (string)rdr["FirstName"];
                    currentPerson.LastName = (string)rdr["LastName"];
                    currentPerson.Nationality = (string)rdr["Nationality"];
                    currentPerson.Gender = (string)rdr["Gender"];
                    currentPerson.AddressID = (long)rdr["AddressID"];
                    p = currentPerson;
                }
            }
        }
    }
}