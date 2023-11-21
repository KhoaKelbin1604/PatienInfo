using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SQLite;

namespace PatienInfo
{
    [Table("Patient")]
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int PatientId { get; set; }
        public string PatientName { get; set;}
        public string Distance {  get; set; }
        public string Elevation { get; set; }
        public DateTime Date { get; set; }
        public string ParkingAvailable { get; set; }
        public string Level { get; set; }
        public string Technicaldifficulty { get; set; }
        public string Location { get; set; }
        public string Descriptions { get; set; }
        public Patient() { }
        public Patient(int patientId, string nameofTrip, string distance, string elevation, DateTime date, string parkingAvailable,
            string level,  string technicaldifficulty, string location , string descriptions) 
        {
            PatientId = patientId;
            PatientName = nameofTrip;
            Distance = distance;
            Elevation = elevation;
            Date = date;
            Level = level;
            ParkingAvailable = parkingAvailable;
            Technicaldifficulty = technicaldifficulty;
            Location = location;
            Descriptions = descriptions;
            
        }    
    }
}
