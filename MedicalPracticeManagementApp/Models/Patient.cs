using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalPracticeManagementApp_.Models
{
    internal class PatientRecord
    {
        public class Patient
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public DateTime Birthdate { get; set; }
            public string Race { get; set; }
            public string Gender { get; set; }
            public string Diagnoses { get; set; }
            public string Prescriptions { get; set; }

            public Patient(string name, string address, DateTime birthdate, string race, string gender, string diagnoses, string prescriptions)
            {
                Name = name;
                Address = address;
                Birthdate = birthdate;
                Race = race;
                Gender = gender;
                Diagnoses = diagnoses;
                Prescriptions = prescriptions;
            }
        }
    }
}
