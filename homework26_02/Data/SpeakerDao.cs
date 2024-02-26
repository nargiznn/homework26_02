using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using homework26_02.Model;

namespace homework26_02.Data
{
	public class SpeakerDao
	{
        public List<Speakers> GetAll()
        {
            List<Speakers> speakers = new List<Speakers>();
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.LOCAL))
            {
                connection.Open();
                string query = "select Id, Fullname,Position,Company from Speakers";
                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Speakers spk = new Speakers
                        {

                            Id = reader.GetInt32(0),
                            FullName = reader.GetString(1),
                            Position = reader.GetString(2),
                            Company = reader.GetString(3),

                        };
                        speakers.Add(spk);
                    }
                }
            }
            return speakers;
        }
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.LOCAL))
            {
                string query = "delete from Speakers where id=@id";

                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        //public int Insert(Speakers speakers)
        //{
        //    var result = 0;
        //    using (SqlConnection connection = new SqlConnection(ConnectionStrings.LOCAL))
        //    {
        //        connection.Open();
        //        string query = "insert into Speakers (fullname,position,company) values (@fullname,@position,@company)";
        //        using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@fullname", speakers.FullName);
        //            cmd.Parameters.AddWithValue("@position", speakers.Position);
        //            cmd.Parameters.AddWithValue("@company", speakers.Company);
        //            result = cmd.ExecuteNonQuery();
        //        }
        //    }
        //    return result;
        //}

        public int Insert(Speakers speakers)
        {
            using (SqlConnection conntection = new SqlConnection(ConnectionStrings.LOCAL))
            {
                string query = "insert into Speakers (fullname,position,company) values (@fullname,@position,@company)";
                conntection.Open();
                using (SqlCommand cmd = new SqlCommand(query, conntection))
                {
                    cmd.Parameters.AddWithValue("@fullname", speakers.FullName);
                    cmd.Parameters.AddWithValue("@position", speakers.Position);
                    cmd.Parameters.AddWithValue("@company", speakers.Company);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int Update(Speakers speakers)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStrings.LOCAL))
            {
                string query = "update Events set fullname=@fullname, position=@position,company=@company where id=@id";

                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fullname", speakers.FullName);
                    cmd.Parameters.AddWithValue("@position", speakers.Position);
                    cmd.Parameters.AddWithValue("@company", speakers.Company);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public Speakers GetById(int id)
        {
            Speakers speakers = null;
            string connectionStr = ConnectionStrings.LOCAL;
            using(SqlConnection connection=new SqlConnection(connectionStr))
            {
                connection.Open();
                string query = "select TOP(1) * from Groups where Id=@id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows) return null;
                    while (reader.Read())
                    {
                        speakers = new Speakers();
                        speakers.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        speakers.FullName = reader.GetString(reader.GetOrdinal("Fullname"));
                        speakers.Position = reader.GetString(reader.GetOrdinal("Position"));
                        speakers.Company = reader.GetString(reader.GetOrdinal("Company"));

                    }
                }

            }return speakers;
        }
        }
}

