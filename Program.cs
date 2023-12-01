using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Больничная_аптека
{
    public class Program
    {
        public static void Main()
        {
           

            Hospital_pharmacy hospital_Pharmacy = new Hospital_pharmacy("Больничная аптека номер 1", new List<Medicine> { });

            Medicine ingavirin = new Medicine(3, "Ingavirin", "Противовирусное", 10);
            Medicine afludol = new Medicine(4, "afludol", "Противовирусное", 15);
            Medicine kagocel = new Medicine(5, "kagocel", "Противовирусное", 0);
            Medicine paracetamol = new Medicine(6, "paracetamol", "Жаропонижающее", 10);
            Medicine pharmstandartC = new Medicine(6, "pharmstandartC", "витамин C", 10);

            hospital_Pharmacy.PharmacyMedList.AddRange(new List<Medicine> { ingavirin, afludol, kagocel, paracetamol, pharmstandartC });

            Console.WriteLine("Список лекарств в больничной аптеке");
            Console.WriteLine("===================================");

            foreach (Medicine str in hospital_Pharmacy.PharmacyMedList)
            {
                
                Console.WriteLine(str.Name);
               
            }
            Console.WriteLine("===================================");


            Patient patient = new Patient(
                1,
                new List<Medicine> {},
                 24,
                "John Doe", "123-456-7890"
                );
            Doctor doctor = new Doctor(
                2,
                new List<Package> { },
                new List<Patient> { patient },
               
                "Shara Sho", "123-456-7890"
                );
         


           // doctor.Patients[0];
           doctor.AddMedicine("paracetamol", "John Doe", hospital_Pharmacy);
            doctor.AddMedicine("kagocel", "John Doe", hospital_Pharmacy);

            doctor.SentRequest(patient, hospital_Pharmacy);
           


        }
    }
}