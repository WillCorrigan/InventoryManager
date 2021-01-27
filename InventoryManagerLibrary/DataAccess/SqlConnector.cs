using InventoryManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreateCase method actually grab from the database.
        /// <summary>
        /// Creates a case in the database.
        /// </summary>
        /// <param name="caseItem">The case information.</param>
        /// <returns>The case information, including the unique identifier.</returns>
        public CaseModel CreateCase(CaseModel caseItem)
        {
            caseItem.Id = 1;

            return caseItem;
        }
    }
}
