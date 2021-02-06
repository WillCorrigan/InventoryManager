using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary.Models
{
    public class CaseTypeModel
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public CaseTypeModel()
        {

        }

        public CaseTypeModel(int caseTypeId, string caseTypeType)
        {
            Id = caseTypeId;
            Type = caseTypeType;
        }
    }
}
