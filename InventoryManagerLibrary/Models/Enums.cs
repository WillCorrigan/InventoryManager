using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary.Models
{
        public enum CaseStatus
        {
            [Description("In Progress")]
            InProgress = 1,
            [Description("Completed")]
            Completed = 2,
            [Description("To Be Prepared")]
            ToBePrepared = 3,
            [Description("Cleared")]
            Cleared = 4,
            [Description("Cancelled")]
            Cancelled = 5
    }

    public enum DatabaseType
    {
        Sql,
        TextFile
    }
}
