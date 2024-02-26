using System;
namespace homework26_02.Model
{
	public class Events
	{
		public Events()
		{
		}

        public Events(int id, string name,string desc,string address,DateTime startdate,DateTime starttime,DateTime endtime)
        {
            Id = id;
            Name = name;
            Address = address;
            StartDate = startdate;
            StarTime = starttime;
            EndTime = endtime;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StarTime { get; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public override string ToString()
        {
            return Id + "-" + Name + "-" + StartDate;
        }
    }
}

