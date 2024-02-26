using System;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using homework26_02.Model;

namespace homework26_02.Data
{
	public class EventDao
	{

        //public int Insert(Events events)
        //{
        //    var result = 0;
        //    using (SqlConnection connection = new SqlConnection(ConnectionStrings.LOCAL))
        //    {
        //        connection.Open();
        //        string query = "Insert into Events(Name, Address, StartDate, StarTime, EndTime) values (@name, @address, @startDate, @starTime, @endTime)";
        //        using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            cmd.Parameters.AddWithValue(@name, events.Name);
        //            cmd.Parameters.AddWithValue(@address, events.Address);
        //            cmd.Parameters.AddWithValue(@startDate, events.StartDate);
        //            cmd.Parameters.AddWithValue(@startTime, events.StarTime);
        //            cmd.Parameters.AddWithValue(@endTime, events.EndTime);
        //            result = cmd.ExecuteNonQuery();

        //        }
        //    }
        //    return result;
        //}

        //public int Update(Events events)
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionStrings.LOCAL))
        //    {
        //        string query = "update Events set no=@no, limit=@limit where id=@id";

        //        connection.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@id", group.Id);
        //            cmd.Parameters.AddWithValue("@no", group.No);
        //            cmd.Parameters.AddWithValue("@limit", group.Limit);

        //            return cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}

