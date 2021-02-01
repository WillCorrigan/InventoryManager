using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerUI
{
    public partial class DashboardForm : Form
    {
        // Global Variables 
        Panel currentActivePanel = null;
        Button currentActiveButton = null;
        Form currentActiveForm = null;


        // On form initialise
        public DashboardForm()
        {
            InitializeComponent();
            AddDropdownMenuClickEvents();
        }


        // Add click events (dropdown menu) toggles to all main menu buttons
        private void AddDropdownMenuClickEvents()
        {
            casesDropdownButton.Click += toggleDropdownMenu;
            equipmentDropdownButton.Click += toggleDropdownMenu;
            teamDropdownButton.Click += toggleDropdownMenu;
            locationsDropdownButton.Click += toggleDropdownMenu;
        }


        // Toggle dropdown menu method (switch statement)
        void toggleDropdownMenu(Object sender, EventArgs e)
        {
            var buttonName = ((Button)sender).Name;
            HighlightActiveButton(sender);

            switch (buttonName)
            {
                case "casesDropdownButton":
                    casesDropdownPanel.Visible = !casesDropdownPanel.Visible;
                    HideOtherDropdowns(casesDropdownPanel);
                    break;
                case "equipmentDropdownButton":
                    equipmentDropdownPanel.Visible = !equipmentDropdownPanel.Visible;
                    HideOtherDropdowns(equipmentDropdownPanel);
                    break;
                case "teamDropdownButton":
                    teamDropdownPanel.Visible = !teamDropdownPanel.Visible;
                    HideOtherDropdowns(teamDropdownPanel);
                    break;
                case "locationsDropdownButton":
                    locationsDropdownPanel.Visible = !locationsDropdownPanel.Visible;
                    HideOtherDropdowns(locationsDropdownPanel);
                    break;
                default:
                    Console.Write("This button isn't registered as toggleable");
                    break;
            }
        }

        // Sets submenu button to active and highlights it (while un-highlighting previous active button)
        private void HighlightActiveButton(Object sender)
        {
            var buttonObject = ((Button)sender);
            if(currentActiveButton == null)
            {
                currentActiveButton = buttonObject;
                currentActiveButton.BackColor = Color.FromArgb(100, 100, 100);
            }
            if (currentActiveButton != buttonObject)
            {
                currentActiveButton.BackColor = Color.FromArgb(32, 34, 37);
                currentActiveButton = ((Button)sender);
                currentActiveButton.BackColor = Color.FromArgb(100, 100, 100);
            }
        }

        // Hides other dropdown menus when another opens
        private void HideOtherDropdowns(Panel panelName)
        {
            if (currentActivePanel == null)
            {
                currentActivePanel = panelName;
            }
            if (panelName != currentActivePanel)
            {
                currentActivePanel.Visible = false;
                currentActivePanel = panelName;
            }
        }

        // Enables application to be dragged around since border is set to none
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        // Opens child form in dashboard main screen
        private void OpenChildForm(Form childForm, object sender)
        {
            if (currentActiveForm != null)
            {
                currentActiveForm.Close();
            }
            currentActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childFormPanel.Controls.Add(childForm);
            this.childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        // Button click methods below


        private void topLogoSpacer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
