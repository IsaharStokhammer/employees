using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees.model
{
    internal class Employee
    {
        public Employee(int id, int tZ, string firstName, string lastName, DateTime dayOfBirth, Gender gender, string mobile, string phone, Address address)
        {
            Id = id;
            TZ = tZ;
            FirstName = firstName;
            LastName = lastName;
            DayOfBirth = dayOfBirth;
            Gender = gender;
            Mobile = mobile;
            Phone = phone;
            Address = address;
        }

        public int Id { get; set; }
        public int TZ { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DayOfBirth { get; set; }

        public Gender Gender {  get; set; }
        
        public string Mobile {  get; set; }
        public string Phone {  get; set; }
        public Address Address { get; set; }


        public string FullName
        {
            get
            {
                return ($"{FirstName} {LastName}");
            }
        }
        public int Age { get { return DateTime.Now.Year - DayOfBirth.Year; } }
    }
}
