using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Больничная_аптека;

namespace Больничная_аптека
{
     class Patient : Person
    {
        public int Id { get; set; }
        public int Ward { get; set; }
        public List<Medicine> MedList { get; set; }

        public Patient(int id, List<Medicine> medList,  int ward, string name, string phoneNumber) : base(name, phoneNumber)
        {
            Id = id;
            MedList = medList;
            Ward = ward;
        }

    }
}
