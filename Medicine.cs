using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Больничная_аптека
{
    class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public int Amount { get; set; }

        public Medicine(int id, string name, string purpose, int amount){
            Id = id;
            Name = name;
            Purpose = purpose;
            Amount = amount;
                
            }
    }
}
