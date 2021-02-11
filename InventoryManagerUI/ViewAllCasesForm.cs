using InventoryManagerLibrary;
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
    public partial class ViewAllCasesForm : Form
    {
        private List<CaseModel> allcases = GlobalConfig.Connection.GetCases_All();

        public ViewAllCasesForm()
        {
            InitializeComponent();
            InitialiseView();
        }

        private void InitialiseView()
        {
            allCasesList.View = View.Details;
            allCasesList.Columns.Add("Case Name", -2, HorizontalAlignment.Left);
            allCasesList.Columns.Add("Start Date", -2, HorizontalAlignment.Left);
            allCasesList.Columns.Add("End Date", -2, HorizontalAlignment.Left);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getAllButton_Click(object sender, EventArgs e)
        {
            foreach (CaseModel caseItem in allcases)
            {
                string strStartDate = caseItem.StartDate.ToString("dd/MM/yyyy");
                string strEndDate = caseItem.EndDate.ToString("dd/MM/yyyy");
                string[] row = { caseItem.CaseName, strStartDate, strEndDate};
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = caseItem;
                allCasesList.Items.Add(listViewItem);
            }
        }

        private void viewSelectedButton_Click(object sender, EventArgs e)
        {
            if (allCasesList.SelectedItems.Count > 0)
            {
                DashboardForm parent = (DashboardForm)ParentForm;
                parent.OpenChildForm(new ViewEditCaseForm((CaseModel)allCasesList.SelectedItems[0].Tag), sender);
                parent.HighlightActiveSubmenuButton(parent.viewCaseButton);
            }
            else
            {
                MessageBox.Show("Nothing is selected", "Error");
            }
        }
    }
}
