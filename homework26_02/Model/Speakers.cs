using System;
namespace homework26_02.Model
{
	public class Speakers
	{
		public Speakers()
		{
		}
        public Speakers(int id, string fullname, string position, string company)
        {
            Id = id;
            FullName = fullname;
            Position = position;
            Company=company;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }

        public override string ToString()
        {
            return Id + "-" + FullName + "-" + Position+" "+Company;
        }
    }
}

