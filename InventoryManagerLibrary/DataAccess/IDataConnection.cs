using InventoryManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary.DataAccess
{
    public interface IDataConnection
    {
        CaseModel CreateCase(CaseModel caseItem);

        List<CaseTypeModel> GetCaseType_All();

        List<CaseModel> GetCases_All();

    }
}
