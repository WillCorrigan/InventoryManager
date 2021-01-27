using InventoryManagerLibrary;
using InventoryManagerLibrary.DataAccess;
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
    public partial class CreateCaseForm : Form
    {
        public CreateCaseForm()
        {
            InitializeComponent();
        }

        private void createCaseButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CaseModel model = new CaseModel(caseNameValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateCase(model);

                }

                caseNameValue.Text = "";
                MessageBox.Show("Case Created.");

                // TODO - Rest of case contents

            }
            else
            {
                MessageBox.Show("This form is invalid, please try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (caseNameValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
