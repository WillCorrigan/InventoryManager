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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            AddDropdownMenuClickEvents();
        }

        private void AddDropdownMenuClickEvents()
        {
            casesDropdownButton.Click += toggleDropdownMenu;
            equipmentDropdownButton.Click += toggleDropdownMenu;
            teamDropdownButton.Click += toggleDropdownMenu;
            locationsDropdownButton.Click += toggleDropdownMenu;


        }


        void toggleDropdownMenu(Object sender, EventArgs e)
        {
            var buttonName = ((Button)sender).Name;

            switch (buttonName)
            {
                case "casesDropdownButton":
                    casesDropdownPanel.Visible = !casesDropdownPanel.Visible;
                    break;
                case "equipmentDropdownButton":
                    equipmentDropdownPanel.Visible = !equipmentDropdownPanel.Visible;
                    break;
                case "teamDropdownButton":
                    teamDropdownPanel.Visible = !teamDropdownPanel.Visible;
                    break;
                case "locationsDropdownButton":
                    locationsDropdownPanel.Visible = !locationsDropdownPanel.Visible;
                    break;
                default:
                    Console.Write("This button isn't registered as toggleable");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void casesDropdownPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
