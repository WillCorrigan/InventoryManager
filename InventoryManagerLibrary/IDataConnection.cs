﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerLibrary
{
    public interface IDataConnection
    {
        CaseModel CreateCase(CaseModel caseItem);

    }
}
