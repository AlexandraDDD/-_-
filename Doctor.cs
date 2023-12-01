using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Больничная_аптека
{
    internal class Doctor  : Person
    {
        public int Id { get; set; }
        public List<Package> Packeges { get; set; }
        public List<Patient> Patients { get; set; }

        public Doctor(int id, List<Package> packeges, List<Patient> patients, string name, string phoneNumber) : base(name, phoneNumber)
        {
            Id = id;
            Packeges = packeges;
            Patients = patients;
        }

        public void AddMedicine(string nameoOfPharmacy, 
            string nameOfPatient, Hospital_pharmacy hospital_Pharmacy)

        {
            Console.WriteLine("Начинаем добавление лекарства");
            string targetNamePharm = nameoOfPharmacy;
            Medicine foundMedicine = null;

            foreach (Medicine medicine in hospital_Pharmacy.PharmacyMedList)
           {
               if (medicine.Name == targetNamePharm)
               {
                    foundMedicine = medicine;
                    
                    break; 
                }
           }
            if (foundMedicine != null)
            {
                // Найден нужный пациент
                Console.WriteLine("Лекарство найдено: " + foundMedicine.Name);
            }
            else
            {
                // Пациент не найден
                Console.WriteLine("Лекарство не найдено.");
            }

            string targetName = nameOfPatient;
                Patient foundPatient = null;

            foreach (Patient patient in this.Patients )
            {
                if (patient.Name == targetName)
                {
                    foundPatient = patient;

                    patient.MedList.Add(foundMedicine);
                    foreach (Medicine e in patient.MedList)
                    {

                        Console.WriteLine(e.Name);

                    }
                    
                    break; // Если пациент найден, завершаем цикл
                }

            }
            if (foundPatient != null)
            {
                // Найден нужный пациент
                Console.WriteLine("Пациент найден: " + foundPatient.Name);
            }
            else
            {
                // Пациент не найден
                Console.WriteLine("Пациент не найден.");
            }
            


        }

        public void SentRequest(Patient patient, Hospital_pharmacy hospital_Pharmacy)
        {
            Console.WriteLine("---Отправка запроса в больничную апетеку---");
            hospital_Pharmacy.checkPatient(patient, hospital_Pharmacy);
        }
    }
}
