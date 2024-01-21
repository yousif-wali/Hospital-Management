using System;
namespace Hospital_Management
{
	public class Doctor
	{
		public string Name { get; set; }
		public string DOB  { get; set; }
		public Certificates[] Certificates { get; set; }
		
		public Doctor(string name, string dob, Certificates[] certificates)
		{
			Name = name;
			DOB = dob;
			Certificates = certificates;
		}
	}
}

