using InventoryManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerUI
{
    public partial class ViewEditCaseForm : Form
    {
        public ViewEditCaseForm(CaseModel caseItem)
        {
            InitializeComponent();
            InitialiseCase(caseItem);
        }

        private void InitialiseCase(CaseModel caseItem)
        {
            caseNameLabel.Text = caseItem.CaseName.ToString();
        }
    }
}
