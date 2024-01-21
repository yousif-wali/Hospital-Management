using System;
using Hospital_Management.Instances;
namespace Hospital_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating Department
            Department ER = new Department("ER1", Doctor_Instance.Doctors, Instrument_Instance.Instruments);
            Department Chiropractic = new Department("Ch2", Doctor_Instance.Doctors, Instrument_Instance.Instruments);

            Hospital hospital = new Hospital("DownTown Hospital", "Main Ave",new List<Department> { ER, Chiropractic});

        }
    }
}