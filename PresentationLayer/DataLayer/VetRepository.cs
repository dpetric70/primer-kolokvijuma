using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class VetRepository
    {
        public List<Vet> GetAllVets()
        {
            List<Vet> vets = new List<Vet>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Vets;";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    int Id = sqlDataReader.GetInt32(0);
                    string FullName = sqlDataReader.GetString(1);
                    string Speciality = sqlDataReader.GetString(2);
                    int YearsExperience = sqlDataReader.GetInt32(3);

                    vets.Add(new Vet(Id, FullName, Speciality, YearsExperience));
                }
            }

            return vets;
        }
        public int InsertVet(Vet x)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Vets VALUES('{0}', '{1}', {2})", x.FullName, x.Speciality, x.YearsExperience);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
