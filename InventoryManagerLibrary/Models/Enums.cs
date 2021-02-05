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
        InProgress,
        Completed,
        [Description("To Be Prepared")]
        ToBePrepared,
        Cleared,
        Cancelled
    }

    public enum CaseType
    {
        EPE = 1,
        RT = 2,
        Daily = 3
    }
}
