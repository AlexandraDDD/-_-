using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Больничная_аптека
{
    class Package
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public DateOnly Date { get; set; }
        public List<Medicine> MedList { get; set; } = new List<Medicine>();

        public Package( Patient patient, DateOnly date, List<Medicine> medList) 
        {
            
            Patient = patient;
            Date = date;
            MedList = medList;
        }
    }
}
