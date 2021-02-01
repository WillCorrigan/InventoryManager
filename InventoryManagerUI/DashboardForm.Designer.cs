
namespace InventoryManagerUI
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.taskbarleftPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.casesDropdownButton = new System.Windows.Forms.Button();
            this.casesDropdownPanel = new System.Windows.Forms.Panel();
            this.viewAllCasesButton = new System.Windows.Forms.Button();
            this.viewCaseButton = new System.Windows.Forms.Button();
            this.editCaseButton = new System.Windows.Forms.Button();
            this.createCaseButton = new System.Windows.Forms.Button();
            this.equipmentDropdownButton = new System.Windows.Forms.Button();
            this.equipmentDropdownPanel = new System.Windows.Forms.Panel();
            this.viewAllEquipmentButton = new System.Windows.Forms.Button();
            this.viewEquipmentButton = new System.Windows.Forms.Button();
            this.editEquipmentButton = new System.Windows.Forms.Button();
            this.createEquipmentButton = new System.Windows.Forms.Button();
            this.teamDropdownButton = new System.Windows.Forms.Button();
            this.teamDropdownPanel = new System.Windows.Forms.Panel();
            this.viewAllTeamMembersButton = new System.Windows.Forms.Button();
            this.viewTeamMemberButton = new System.Windows.Forms.Button();
            this.editTeamMemberButton = new System.Windows.Forms.Button();
            this.createTeamMemberButton = new System.Windows.Forms.Button();
            this.locationsDropdownButton = new System.Windows.Forms.Button();
            this.locationsDropdownPanel = new System.Windows.Forms.Panel();
            this.viewAllLocationsButton = new System.Windows.Forms.Button();
            this.viewLocationButton = new System.Windows.Forms.Button();
            this.editLocationButton = new System.Windows.Forms.Button();
            this.createLocationButton = new System.Windows.Forms.Button();
            this.supportButton = new System.Windows.Forms.Button();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.exitButtonPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.bottomLogoSpacer = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.taskbarRightPanel = new System.Windows.Forms.Panel();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.casesDropdownPanel.SuspendLayout();
            this.equipmentDropdownPanel.SuspendLayout();
            this.teamDropdownPanel.SuspendLayout();
            this.locationsDropdownPanel.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            this.exitButtonPanel.SuspendLayout();
            this.childFormPanel.SuspendLayout();
            this.taskbarRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbarleftPanel
            // 
            this.taskbarleftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskbarleftPanel.Location = new System.Drawing.Point(0, 0);
            this.taskbarleftPanel.Name = "taskbarleftPanel";
            this.taskbarleftPanel.Size = new System.Drawing.Size(250, 32);
            this.taskbarleftPanel.TabIndex = 0;
            this.taskbarleftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topLogoSpacer_MouseDown);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 32);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 110);
            this.logoPanel.TabIndex = 0;
            // 
            // casesDropdownButton
            // 
            this.casesDropdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.casesDropdownButton.FlatAppearance.BorderSize = 0;
            this.casesDropdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casesDropdownButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.casesDropdownButton.Location = new System.Drawing.Point(0, 197);
            this.casesDropdownButton.Name = "casesDropdownButton";
            this.casesDropdownButton.Size = new System.Drawing.Size(250, 60);
            this.casesDropdownButton.TabIndex = 1;
            this.casesDropdownButton.Text = "Cases";
            this.casesDropdownButton.UseVisualStyleBackColor = true;
            // 
            // casesDropdownPanel
            // 
            this.casesDropdownPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.casesDropdownPanel.Controls.Add(this.viewAllCasesButton);
            this.casesDropdownPanel.Controls.Add(this.viewCaseButton);
            this.casesDropdownPanel.Controls.Add(this.editCaseButton);
            this.casesDropdownPanel.Controls.Add(this.createCaseButton);
            this.casesDropdownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.casesDropdownPanel.Location = new System.Drawing.Point(0, 257);
            this.casesDropdownPanel.Name = "casesDropdownPanel";
            this.casesDropdownPanel.Size = new System.Drawing.Size(250, 172);
            this.casesDropdownPanel.TabIndex = 2;
            this.casesDropdownPanel.Visible = false;
            // 
            // viewAllCasesButton
            // 
            this.viewAllCasesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewAllCasesButton.FlatAppearance.BorderSize = 0;
            this.viewAllCasesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllCasesButton.ForeColor = System.Drawing.Color.LightGray;
            this.viewAllCasesButton.Location = new System.Drawing.Point(0, 120);
            this.viewAllCasesButton.Name = "viewAllCasesButton";
            this.viewAllCasesButton.Size = new System.Drawing.Size(250, 40);
            this.viewAllCasesButton.TabIndex = 3;
            this.viewAllCasesButton.Text = "View All";
            this.viewAllCasesButton.UseVisualStyleBackColor = true;
            // 
            // viewCaseButton
            // 
            this.viewCaseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewCaseButton.FlatAppearance.BorderSize = 0;
            this.viewCaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCaseButton.ForeColor = System.Drawing.Color.LightGray;
            this.viewCaseButton.Location = new System.Drawing.Point(0, 80);
            this.viewCaseButton.Name = "viewCaseButton";
            this.viewCaseButton.Size = new System.Drawing.Size(250, 40);
            this.viewCaseButton.TabIndex = 2;
            this.viewCaseButton.Text = "View Case";
            this.viewCaseButton.UseVisualStyleBackColor = true;
            // 
            // editCaseButton
            // 
            this.editCaseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editCaseButton.FlatAppearance.BorderSize = 0;
            this.editCaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCaseButton.ForeColor = System.Drawing.Color.LightGray;
            this.editCaseButton.Location = new System.Drawing.Point(0, 40);
            this.editCaseButton.Name = "editCaseButton";
            this.editCaseButton.Size = new System.Drawing.Size(250, 40);
            this.editCaseButton.TabIndex = 1;
            this.editCaseButton.Text = "Edit Case";
            this.editCaseButton.UseVisualStyleBackColor = true;
            // 
            // createCaseButton
            // 
            this.createCaseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createCaseButton.FlatAppearance.BorderSize = 0;
            this.createCaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCaseButton.ForeColor = System.Drawing.Color.LightGray;
            this.createCaseButton.Location = new System.Drawing.Point(0, 0);
            this.createCaseButton.Name = "createCaseButton";
            this.createCaseButton.Size = new System.Drawing.Size(250, 40);
            this.createCaseButton.TabIndex = 0;
            this.createCaseButton.Text = "Create Case";
            this.createCaseButton.UseVisualStyleBackColor = true;
            // 
            // equipmentDropdownButton
            // 
            this.equipmentDropdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipmentDropdownButton.FlatAppearance.BorderSize = 0;
            this.equipmentDropdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equipmentDropdownButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.equipmentDropdownButton.Location = new System.Drawing.Point(0, 429);
            this.equipmentDropdownButton.Name = "equipmentDropdownButton";
            this.equipmentDropdownButton.Size = new System.Drawing.Size(250, 60);
            this.equipmentDropdownButton.TabIndex = 3;
            this.equipmentDropdownButton.Text = "Equipment";
            this.equipmentDropdownButton.UseVisualStyleBackColor = true;
            // 
            // equipmentDropdownPanel
            // 
            this.equipmentDropdownPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.equipmentDropdownPanel.Controls.Add(this.viewAllEquipmentButton);
            this.equipmentDropdownPanel.Controls.Add(this.viewEquipmentButton);
            this.equipmentDropdownPanel.Controls.Add(this.editEquipmentButton);
            this.equipmentDropdownPanel.Controls.Add(this.createEquipmentButton);
            this.equipmentDropdownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipmentDropdownPanel.Location = new System.Drawing.Point(0, 489);
            this.equipmentDropdownPanel.Name = "equipmentDropdownPanel";
            this.equipmentDropdownPanel.Size = new System.Drawing.Size(250, 172);
            this.equipmentDropdownPanel.TabIndex = 4;
            this.equipmentDropdownPanel.Visible = false;
            // 
            // viewAllEquipmentButton
            // 
            this.viewAllEquipmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewAllEquipmentButton.FlatAppearance.BorderSize = 0;
            this.viewAllEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllEquipmentButton.ForeColor = System.Drawing.Color.LightGray;
            this.viewAllEquipmentButton.Location = new System.Drawing.Point(0, 120);
            this.viewAllEquipmentButton.Name = "viewAllEquipmentButton";
            this.viewAllEquipmentButton.Size = new System.Drawing.Size(250, 40);
            this.viewAllEquipmentButton.TabIndex = 3;
            this.viewAllEquipmentButton.Text = "View All";
            this.viewAllEquipmentButton.UseVisualStyleBackColor = true;
            // 
            // viewEquipmentButton
            // 
            this.viewEquipmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewEquipmentButton.FlatAppearance.BorderSize = 0;
            this.viewEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEquipmentButton.ForeColor = System.Drawing.Color.LightGray;
            this.viewEquipmentButton.Location = new System.Drawing.Point(0, 80);
            this.viewEquipmentButton.Name = "viewEquipmentButton";
            this.viewEquipmentButton.Size = new System.Drawing.Size(250, 40);
            this.viewEquipmentButton.TabIndex = 2;
            this.viewEquipmentButton.Text = "View Equipment";
            this.viewEquipmentButton.UseVisualStyleBackColor = true;
            // 
            // editEquipmentButton
            // 
            this.editEquipmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editEquipmentButton.FlatAppearance.BorderSize = 0;
            this.editEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEquipmentButton.ForeColor = System.Drawing.Color.LightGray;
            this.editEquipmentButton.Location = new System.Drawing.Point(0, 40);
            this.editEquipmentButton.Name = "editEquipmentButton";
            this.editEquipmentButton.Size = new System.Drawing.Size(250, 40);
            this.editEquipmentButton.TabIndex = 1;
            this.editEquipmentButton.Text = "Edit Equipment";
            this.editEquipmentButton.UseVisualStyleBackColor = true;
            // 
            // createEquipmentButton
            // 
            this.createEquipmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createEquipmentButton.FlatAppearance.BorderSize = 0;
            this.createEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createEquipmentButton.ForeColor = System.Drawing.Color.LightGray;
            this.createEquipmentButton.Location = new System.Drawing.Point(0, 0);
            this.createEquipmentButton.Name = "createEquipmentButton";
            this.createEquipmentButton.Size = new System.Drawing.Size(250, 40);
            this.createEquipmentButton.TabIndex = 0;
            this.createEquipmentButton.Text = "Create Equipment";
            this.createEquipmentButton.UseVisualStyleBackColor = true;
            // 
            // teamDropdownButton
            // 
            this.teamDropdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamDropdownButton.FlatAppearance.BorderSize = 0;
            this.teamDropdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamDropdownButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.teamDropdownButton.Location = new System.Drawing.Point(0, 661);
            this.teamDropdownButton.Name = "teamDropdownButton";
            this.teamDropdownButton.Size = new System.Drawing.Size(250, 60);
            this.teamDropdownButton.TabIndex = 5;
            this.teamDropdownButton.Text = "Team";
            this.teamDropdownButton.UseVisualStyleBackColor = true;
            // 
            // teamDropdownPanel
            // 
            this.teamDropdownPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.teamDropdownPanel.Controls.Add(this.viewAllTeamMembersButton);
            this.teamDropdownPanel.Controls.Add(this.viewTeamMemberButton);
            this.teamDropdownPanel.Controls.Add(this.editTeamMemberButton);
            this.teamDropdownPanel.Controls.Add(this.createTeamMemberButton);
            this.teamDropdownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamDropdownPanel.Location = new System.Drawing.Point(0, 721);
            this.teamDropdownPanel.Name = "teamDropdownPanel";
            this.teamDropdownPanel.Size = new System.Drawing.Size(250, 172);
            this.teamDropdownPanel.TabIndex = 6;
            this.teamDropdownPanel.Visible = false;
            // 
            // viewAllTeamMembersButton
            // 
            this.viewAllTeamMembersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewAllTeamMembersButton.FlatAppearance.BorderSize = 0;
            this.viewAllTeamMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllTeamMembersButton.ForeColor = System.Drawing.Color.LightGray;
            this.viewAllTeamMembersButton.Location = new System.Drawing.Point(0, 120);
            this.viewAllTeamMembersButton.Name = "viewAllTeamMembersButton";
            this.viewAllTeamMembersButton.Size = new System.Drawing.Size(250, 40);
            this.viewAllTeamMembersButton.TabIndex = 3;
            this.viewAllTeamMembersButton.Text = "View All";
            this.viewAllTeamMembersButton.UseVisualStyleBackColor = true;
            // 
            // viewTeamMemberButton
            // 
            this.viewTeamMemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewTeamMemberButton.FlatAppearance.BorderSize = 0;
            this.viewTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTeamMemberButton.ForeColor = System.Drawing.Color.LightGray;
            this.viewTeamMemberButton.Location = new System.Drawing.Point(0, 80);
            this.viewTeamMemberButton.Name = "viewTeamMemberButton";
            this.viewTeamMemberButton.Size = new System.Drawing.Size(250, 40);
            this.viewTeamMemberButton.TabIndex = 2;
            this.viewTeamMemberButton.Text = "View Member";
            this.viewTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // editTeamMemberButton
            // 
            this.editTeamMemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editTeamMemberButton.FlatAppearance.BorderSize = 0;
            this.editTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTeamMemberButton.ForeColor = System.Drawing.Color.LightGray;
            this.editTeamMemberButton.Location = new System.Drawing.Point(0, 40);
            this.editTeamMemberButton.Name = "editTeamMemberButton";
            this.editTeamMemberButton.Size = new System.Drawing.Size(250, 40);
            this.editTeamMemberButton.TabIndex = 1;
            this.editTeamMemberButton.Text = "Edit Member";
            this.editTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamMemberButton
            // 
            this.createTeamMemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createTeamMemberButton.FlatAppearance.BorderSize = 0;
            this.createTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamMemberButton.ForeColor = System.Drawing.Color.LightGray;
            this.createTeamMemberButton.Location = new System.Drawing.Point(0, 0);
            this.createTeamMemberButton.Name = "createTeamMemberButton";
            this.createTeamMemberButton.Size = new System.Drawing.Size(250, 40);
            this.createTeamMemberButton.TabIndex = 0;
            this.createTeamMemberButton.Text = "Create Member";
            this.createTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // locationsDropdownButton
            // 
            this.locationsDropdownButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationsDropdownButton.FlatAppearance.BorderSize = 0;
            this.locationsDropdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationsDropdownButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.locationsDropdownButton.Location = new System.Drawing.Point(0, 893);
            this.locationsDropdownButton.Name = "locationsDropdownButton";
            this.locationsDropdownButton.Size = new System.Drawing.Size(250, 60);
            this.locationsDropdownButton.TabIndex = 7;
            this.locationsDropdownButton.Text = "Locations";
            this.locationsDropdownButton.UseVisualStyleBackColor = true;
            // 
            // locationsDropdownPanel
            // 
            this.locationsDropdownPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.locationsDropdownPanel.Controls.Add(this.viewAllLocationsButton);
            this.locationsDropdownPanel.Controls.Add(this.viewLocationButton);
            this.locationsDropdownPanel.Controls.Add(this.editLocationButton);
            this.locationsDropdownPanel.Controls.Add(this.createLocationButton);
            this.locationsDropdownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationsDropdownPanel.Location = new System.Drawing.Point(0, 953);
            this.locationsDropdownPanel.Name = "locationsDropdownPanel";
            this.locationsDropdownPanel.Size = new System.Drawing.Size(250, 172);
            this.locationsDropdownPanel.TabIndex = 8;
            this.locationsDropdownPanel.Visible = false;
            // 
            // viewAllLocationsButton
            // 
            this.viewAllLocationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewAllLocationsButton.FlatAppearance.BorderSize = 0;
            this.viewAllLocationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllLocationsButton.ForeColor = System.Drawing.Color.LightGray;
            this.viewAllLocationsButton.Location = new System.Drawing.Point(0, 120);
            this.viewAllLocationsButton.Name = "viewAllLocationsButton";
            this.viewAllLocationsButton.Size = new System.Drawing.Size(250, 40);
            this.viewAllLocationsButton.TabIndex = 3;
            this.viewAllLocationsButton.Text = "View All";
            this.viewAllLocationsButton.UseVisualStyleBackColor = true;
            // 
            // viewLocationButton
            // 
            this.viewLocationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewLocationButton.FlatAppearance.BorderSize = 0;
            this.viewLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLocationButton.ForeColor = System.Drawing.Color.LightGray;
            this.viewLocationButton.Location = new System.Drawing.Point(0, 80);
            this.viewLocationButton.Name = "viewLocationButton";
            this.viewLocationButton.Size = new System.Drawing.Size(250, 40);
            this.viewLocationButton.TabIndex = 2;
            this.viewLocationButton.Text = "View Location";
            this.viewLocationButton.UseVisualStyleBackColor = true;
            // 
            // editLocationButton
            // 
            this.editLocationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editLocationButton.FlatAppearance.BorderSize = 0;
            this.editLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLocationButton.ForeColor = System.Drawing.Color.LightGray;
            this.editLocationButton.Location = new System.Drawing.Point(0, 40);
            this.editLocationButton.Name = "editLocationButton";
            this.editLocationButton.Size = new System.Drawing.Size(250, 40);
            this.editLocationButton.TabIndex = 1;
            this.editLocationButton.Text = "Edit Location";
            this.editLocationButton.UseVisualStyleBackColor = true;
            // 
            // createLocationButton
            // 
            this.createLocationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createLocationButton.FlatAppearance.BorderSize = 0;
            this.createLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createLocationButton.ForeColor = System.Drawing.Color.LightGray;
            this.createLocationButton.Location = new System.Drawing.Point(0, 0);
            this.createLocationButton.Name = "createLocationButton";
            this.createLocationButton.Size = new System.Drawing.Size(250, 40);
            this.createLocationButton.TabIndex = 0;
            this.createLocationButton.Text = "Create Location";
            this.createLocationButton.UseVisualStyleBackColor = true;
            // 
            // supportButton
            // 
            this.supportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supportButton.FlatAppearance.BorderSize = 0;
            this.supportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supportButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.supportButton.Location = new System.Drawing.Point(0, 1125);
            this.supportButton.Name = "supportButton";
            this.supportButton.Size = new System.Drawing.Size(250, 60);
            this.supportButton.TabIndex = 9;
            this.supportButton.Text = "Support";
            this.supportButton.UseVisualStyleBackColor = true;
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.sideMenuPanel.Controls.Add(this.exitButtonPanel);
            this.sideMenuPanel.Controls.Add(this.supportButton);
            this.sideMenuPanel.Controls.Add(this.locationsDropdownPanel);
            this.sideMenuPanel.Controls.Add(this.locationsDropdownButton);
            this.sideMenuPanel.Controls.Add(this.teamDropdownPanel);
            this.sideMenuPanel.Controls.Add(this.teamDropdownButton);
            this.sideMenuPanel.Controls.Add(this.equipmentDropdownPanel);
            this.sideMenuPanel.Controls.Add(this.equipmentDropdownButton);
            this.sideMenuPanel.Controls.Add(this.casesDropdownPanel);
            this.sideMenuPanel.Controls.Add(this.casesDropdownButton);
            this.sideMenuPanel.Controls.Add(this.bottomLogoSpacer);
            this.sideMenuPanel.Controls.Add(this.logoPanel);
            this.sideMenuPanel.Controls.Add(this.taskbarleftPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(250, 771);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // exitButtonPanel
            // 
            this.exitButtonPanel.Controls.Add(this.exitButton);
            this.exitButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButtonPanel.Location = new System.Drawing.Point(0, 671);
            this.exitButtonPanel.Name = "exitButtonPanel";
            this.exitButtonPanel.Size = new System.Drawing.Size(250, 100);
            this.exitButtonPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(0, 34);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(250, 66);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bottomLogoSpacer
            // 
            this.bottomLogoSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomLogoSpacer.Location = new System.Drawing.Point(0, 142);
            this.bottomLogoSpacer.Name = "bottomLogoSpacer";
            this.bottomLogoSpacer.Size = new System.Drawing.Size(250, 55);
            this.bottomLogoSpacer.TabIndex = 10;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.childFormPanel.Controls.Add(this.taskbarRightPanel);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.childFormPanel.Location = new System.Drawing.Point(250, 0);
            this.childFormPanel.MinimumSize = new System.Drawing.Size(950, 600);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(994, 771);
            this.childFormPanel.TabIndex = 2;
            // 
            // taskbarRightPanel
            // 
            this.taskbarRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.taskbarRightPanel.Controls.Add(this.minimiseButton);
            this.taskbarRightPanel.Controls.Add(this.closeButton);
            this.taskbarRightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskbarRightPanel.Location = new System.Drawing.Point(0, 0);
            this.taskbarRightPanel.Name = "taskbarRightPanel";
            this.taskbarRightPanel.Size = new System.Drawing.Size(994, 32);
            this.taskbarRightPanel.TabIndex = 0;
            this.taskbarRightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.minimiseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimiseButton.FlatAppearance.BorderSize = 0;
            this.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.minimiseButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.minimiseButton.Location = new System.Drawing.Point(942, 0);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(26, 32);
            this.minimiseButton.TabIndex = 1;
            this.minimiseButton.Text = "-";
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.closeButton.Location = new System.Drawing.Point(968, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 32);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 771);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(3440, 1400);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.casesDropdownPanel.ResumeLayout(false);
            this.equipmentDropdownPanel.ResumeLayout(false);
            this.teamDropdownPanel.ResumeLayout(false);
            this.locationsDropdownPanel.ResumeLayout(false);
            this.sideMenuPanel.ResumeLayout(false);
            this.exitButtonPanel.ResumeLayout(false);
            this.childFormPanel.ResumeLayout(false);
            this.taskbarRightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel taskbarleftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button casesDropdownButton;
        private System.Windows.Forms.Panel casesDropdownPanel;
        private System.Windows.Forms.Button viewAllCasesButton;
        private System.Windows.Forms.Button viewCaseButton;
        private System.Windows.Forms.Button editCaseButton;
        private System.Windows.Forms.Button createCaseButton;
        private System.Windows.Forms.Button equipmentDropdownButton;
        private System.Windows.Forms.Panel equipmentDropdownPanel;
        private System.Windows.Forms.Button viewAllEquipmentButton;
        private System.Windows.Forms.Button viewEquipmentButton;
        private System.Windows.Forms.Button editEquipmentButton;
        private System.Windows.Forms.Button createEquipmentButton;
        private System.Windows.Forms.Button teamDropdownButton;
        private System.Windows.Forms.Panel teamDropdownPanel;
        private System.Windows.Forms.Button viewAllTeamMembersButton;
        private System.Windows.Forms.Button viewTeamMemberButton;
        private System.Windows.Forms.Button editTeamMemberButton;
        private System.Windows.Forms.Button createTeamMemberButton;
        private System.Windows.Forms.Button locationsDropdownButton;
        private System.Windows.Forms.Panel locationsDropdownPanel;
        private System.Windows.Forms.Button viewAllLocationsButton;
        private System.Windows.Forms.Button viewLocationButton;
        private System.Windows.Forms.Button editLocationButton;
        private System.Windows.Forms.Button createLocationButton;
        private System.Windows.Forms.Button supportButton;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Panel bottomLogoSpacer;
        private System.Windows.Forms.Panel exitButtonPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel taskbarRightPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimiseButton;
    }
}