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
        private List<CaseTypeModel> availableCaseTypes = GlobalConfig.Connection.GetCaseType_All();

        public CreateCaseForm()
        {
            InitializeComponent();
            WireUpLists();
        }


        private void WireUpLists()
        {
            caseTypeValue.ValueMember = "Id";
            caseTypeValue.DataSource = availableCaseTypes;
            caseTypeValue.DisplayMember = "Type";
        }

        private void createCaseButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                CaseTypeModel sendCaseTypeObject = ((CaseTypeModel)caseTypeValue.SelectedItem);
                CaseModel model = new CaseModel(caseNameValue.Text, startDateValue.Text, endDateValue.Text, startTimeValue.Text, sendCaseTypeObject);

                GlobalConfig.Connection.CreateCase(model);

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






        private void caseNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createCaseLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
