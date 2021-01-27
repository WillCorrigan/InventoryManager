using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary
{
    public class EquipmentModel
    {
        public string Name { get; set; }

        public string Barcode { get; set; }

        public string SerialNumber { get; set; }

        public DateTime DateEntered { get; set; }

        public PersonModel EnteredBy { get; set; }



    }
}
