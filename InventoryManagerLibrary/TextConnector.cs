using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the GetCase for text files.
        public CaseModel CreateCase(CaseModel caseItem)
        {
            caseItem.Id = 1;

            return caseItem;
        }
    }
}
