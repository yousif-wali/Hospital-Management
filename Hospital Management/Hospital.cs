using System;
namespace Hospital_Management
{
	public class Hospital
	{
		public string Title { get; set; }
		public string Address { get; set; }
		private List<Department> departments { get; set; }
		public Hospital(string title, string address, List<Department> department)
		{
			Title = title;
			Address = address;	
			departments = department;
			Console.WriteLine("Hospital Initiated");
		}
        public void AddDepartment(Department department)
        {
            departments.Add(department);			
        }
		public void RemoveDepartment(Department department)
		{
			departments.Remove(department);
		}
    }
}

