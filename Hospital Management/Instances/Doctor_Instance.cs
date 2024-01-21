using System;
namespace Hospital_Management.Instances
{
	public static class Doctor_Instance
	{
		// These are randomly generated Doctor names and Date of Birth, and randomly given Certificates
		public static HashSet<Doctor> Doctors = new HashSet<Doctor>
			{
			new Doctor("John Smith", "1999-03-10", new Certificates[]{ Certificates.Doctor_of_Medicine }),
			new Doctor("Uncle Sam", "1975-04-02", new Certificates[]{ Certificates.Doctor_of_Philophy, Certificates.Doctor_of_Public_Health}),
			new Doctor("Viola Gardner", "1983-10-02", new Certificates[]{ Certificates.Doctor_of_Nursing_Practice}),
			new Doctor("Alice Blanchard", "1992-07-12", new Certificates[]{ Certificates.Doctor_of_Dental_Surgery}),
			new Doctor("Wiktor Rubio", "1995-06-19", new Certificates[]{ Certificates.Doctor_of_Medicine}),
			new Doctor("Nadine Calhoun", "2000-01-01", new Certificates[]{Certificates.Doctor_of_Optometry}),
			new Doctor("Sian Velasquez", "1998-06-20", new Certificates[]{ Certificates.Doctor_of_Medicine, Certificates.Doctor_of_Philophy, Certificates.Doctor_of_Optometry}),
			new Doctor("Edna Hodge", "1968-11-01", new Certificates[]{  Certificates.Doctor_of_Public_Health, Certificates.Doctor_of_Podiatric_Medicine, Certificates.Doctor_of_Chiropractic}),
			new Doctor("Seren Cotton", "1987-03-16", new Certificates[] { Certificates.Doctor_of_Medicine}),
			new Doctor("Katie Watts", "1992-06-12", new Certificates[] { Certificates.Doctor_of_Philophy})
			};
	}
}

