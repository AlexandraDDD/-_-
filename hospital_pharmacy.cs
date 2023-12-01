using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Больничная_аптека
{
     class Hospital_pharmacy
    {
        public string Name { get; set; }
        public List<Medicine> PharmacyMedList { get; set; }

        public Hospital_pharmacy(string name, List<Medicine> pharmacyMedList)
        {
            Name = name;
            PharmacyMedList = pharmacyMedList;
        }

        public void sentPackage(Patient patient, List<Medicine> medlist)
        { 
            Package package = new Package( patient,
                DateOnly.FromDateTime(DateTime.Now), medlist );

            Console.WriteLine("=================");
            Console.WriteLine($"пакет сформирован для {patient.Name} в палату номер {patient.Ward} ");
            Console.WriteLine("Список отправленных лекарств: ");
            foreach (Medicine medicine in package.MedList)
            {
                Console.WriteLine(medicine.Name);
            }

        }
        public void checkPatient(Patient patient, Hospital_pharmacy hospital_Pharmacy)
        {
            Console.WriteLine("=================");
            Console.WriteLine($"Проверка пациента {patient.Name}");
            if (patient.MedList.Count != 0)
            {
                Console.WriteLine("У Пациента есть назначенные лекарства");
                IEnumerable<Medicine> missingItems = patient.MedList.Except(hospital_Pharmacy.PharmacyMedList);

                int missingItemslength = missingItems.Count();

                if (missingItemslength == 0)
                {
                    //foreach (Medicine item in patient.MedList)
                    for (int i = 0; i < patient.MedList.Count; i++)
                    {
                        Medicine item = patient.MedList.ElementAt(i);

                        string targetName = item.Name;
                        Medicine foundMedicine = null;

                        foreach (Medicine medicine in hospital_Pharmacy.PharmacyMedList)
                        {
                            if (medicine.Name == targetName)
                            {
                                foundMedicine = medicine;

                                break;
                            }
                        }

                        if (foundMedicine.Amount == 0)
                        {
                            Console.WriteLine($"Лекарство {foundMedicine.Name} закончилось");
                            Console.WriteLine("================");
                            Console.WriteLine("Поиск аналога");
                            foreach (Medicine medicine in hospital_Pharmacy.PharmacyMedList)
                            {
                                if (foundMedicine.Purpose == medicine.Purpose && medicine.Amount != 0)
                                {
                                    Console.WriteLine($"Найденный аналог --- {medicine.Name}");
                                    patient.MedList.Add(medicine);
                                    patient.MedList.Remove(foundMedicine);

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Произведен заказ лекарства(код программы не готов");
                                }
                            }

                        }

                        else
                        {
                            Console.WriteLine($"Лекарство {foundMedicine.Name} есть в наличии");
                        }
                        
                           
                    }
                    Console.WriteLine($"Список лекарств пациента {patient.Name} после проверки ");
                    foreach (Medicine medicine in patient.MedList)
                    {
                        Console.WriteLine(medicine.Name);
                    }
                    Console.WriteLine("=================");
                    hospital_Pharmacy.sentPackage(patient, patient.MedList);
                    
                    
                }
                else
                {
                    Console.WriteLine("Отсутствующие элементы:");
                    foreach (Medicine item in missingItems)
                    {
                        Console.WriteLine(item);
                    }

                }
            }
            else
            {
                Console.WriteLine("У Пациента нет назначенных лекарств");
            }

          
           
          
        }

        
    }
}
