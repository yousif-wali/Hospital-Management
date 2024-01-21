using System;
namespace Hospital_Management
{
	public class Department
	{
		public string Title { get; set; }
		private HashSet<Doctor> Doctors { get; set; }
		private HashSet<Instrument> Instruments { get; set; }
		public Department(string title, HashSet<Doctor> doctors, HashSet<Instrument> instruments)
		{
			Title = title;
			Doctors = doctors;
			Instruments = instruments;
			Console.WriteLine("Department has been created!");
		}
		public void AddDoctors(Doctor doctor)
		{
			Doctors.Add(doctor);
			Console.WriteLine($"Doctor: {doctor.Name} has been added to {this.Title} department");
		}
		public void RemoveDoctors(Doctor doctor)
		{
			Doctors.Remove(doctor);
            Console.WriteLine($"Doctor: {doctor.Name} has been removed from {this.Title} department");
        }
		public void AddInstrument(Instrument instrument)
		{
			Instruments.Add(instrument);
		}
		public void RemoveInstrument(Instrument instrument)
		{
			Instruments.Remove(instrument);
		}
		public void MoveInstrument(Instrument instrument, Department department)
		{
			this.RemoveInstrument(instrument);
			department.AddInstrument(instrument);
			Console.WriteLine($"{instrument.Title} has been move from {this.Title} to {department.Title}");
		}
	}
}

