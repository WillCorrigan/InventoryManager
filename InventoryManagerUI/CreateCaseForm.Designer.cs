
namespace InventoryManagerUI
{
    partial class CreateCaseForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.createCaseTitleLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.startTimeValue = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endDateValue = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateValue = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.createCaseButton = new System.Windows.Forms.Button();
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.caseNameValue = new System.Windows.Forms.TextBox();
            this.createCaseFormPanel = new System.Windows.Forms.Panel();
            this.caseTypeValue = new System.Windows.Forms.ComboBox();
            this.caseTypeLabel = new System.Windows.Forms.Label();
            this.locationValue = new System.Windows.Forms.ComboBox();
            this.titlePanel.SuspendLayout();
            this.createCaseFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.createCaseTitleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(978, 97);
            this.titlePanel.TabIndex = 11;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // createCaseTitleLabel
            // 
            this.createCaseTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createCaseTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.createCaseTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createCaseTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.createCaseTitleLabel.Name = "createCaseTitleLabel";
            this.createCaseTitleLabel.Size = new System.Drawing.Size(978, 97);
            this.createCaseTitleLabel.TabIndex = 0;
            this.createCaseTitleLabel.Text = "Create Case";
            this.createCaseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.locationLabel.Location = new System.Drawing.Point(59, 359);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(66, 17);
            this.locationLabel.TabIndex = 10;
            this.locationLabel.Text = "Location:";
            // 
            // startTimeValue
            // 
            this.startTimeValue.CustomFormat = "HH:mm tt";
            this.startTimeValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeValue.Location = new System.Drawing.Point(152, 306);
            this.startTimeValue.Margin = new System.Windows.Forms.Padding(4);
            this.startTimeValue.Name = "startTimeValue";
            this.startTimeValue.ShowUpDown = true;
            this.startTimeValue.Size = new System.Drawing.Size(100, 23);
            this.startTimeValue.TabIndex = 8;
            this.startTimeValue.Value = new System.DateTime(2021, 2, 6, 14, 23, 0, 0);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startTimeLabel.Location = new System.Drawing.Point(59, 306);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(77, 17);
            this.startTimeLabel.TabIndex = 7;
            this.startTimeLabel.Text = "Start Time:";
            // 
            // endDateValue
            // 
            this.endDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateValue.Location = new System.Drawing.Point(152, 261);
            this.endDateValue.Margin = new System.Windows.Forms.Padding(4);
            this.endDateValue.Name = "endDateValue";
            this.endDateValue.Size = new System.Drawing.Size(100, 23);
            this.endDateValue.TabIndex = 6;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.endDateLabel.Location = new System.Drawing.Point(59, 261);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(71, 17);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date:";
            // 
            // startDateValue
            // 
            this.startDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateValue.Location = new System.Drawing.Point(152, 215);
            this.startDateValue.Margin = new System.Windows.Forms.Padding(4);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(100, 23);
            this.startDateValue.TabIndex = 4;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startDateLabel.Location = new System.Drawing.Point(59, 220);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(76, 17);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date:";
            // 
            // createCaseButton
            // 
            this.createCaseButton.Location = new System.Drawing.Point(404, 472);
            this.createCaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.createCaseButton.Name = "createCaseButton";
            this.createCaseButton.Size = new System.Drawing.Size(100, 28);
            this.createCaseButton.TabIndex = 2;
            this.createCaseButton.Text = "Create Case";
            this.createCaseButton.UseVisualStyleBackColor = true;
            this.createCaseButton.Click += new System.EventHandler(this.createCaseButton_Click);
            // 
            // caseNameLabel
            // 
            this.caseNameLabel.AutoSize = true;
            this.caseNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.caseNameLabel.Location = new System.Drawing.Point(59, 171);
            this.caseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caseNameLabel.Name = "caseNameLabel";
            this.caseNameLabel.Size = new System.Drawing.Size(85, 17);
            this.caseNameLabel.TabIndex = 0;
            this.caseNameLabel.Text = "Case Name:";
            this.caseNameLabel.Click += new System.EventHandler(this.createCaseLabel_Click);
            // 
            // caseNameValue
            // 
            this.caseNameValue.Location = new System.Drawing.Point(152, 168);
            this.caseNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.caseNameValue.Name = "caseNameValue";
            this.caseNameValue.Size = new System.Drawing.Size(287, 23);
            this.caseNameValue.TabIndex = 1;
            this.caseNameValue.TextChanged += new System.EventHandler(this.caseNameValue_TextChanged);
            // 
            // createCaseFormPanel
            // 
            this.createCaseFormPanel.Controls.Add(this.caseTypeValue);
            this.createCaseFormPanel.Controls.Add(this.caseTypeLabel);
            this.createCaseFormPanel.Controls.Add(this.locationValue);
            this.createCaseFormPanel.Controls.Add(this.caseNameValue);
            this.createCaseFormPanel.Controls.Add(this.caseNameLabel);
            this.createCaseFormPanel.Controls.Add(this.createCaseButton);
            this.createCaseFormPanel.Controls.Add(this.startDateLabel);
            this.createCaseFormPanel.Controls.Add(this.startDateValue);
            this.createCaseFormPanel.Controls.Add(this.endDateLabel);
            this.createCaseFormPanel.Controls.Add(this.endDateValue);
            this.createCaseFormPanel.Controls.Add(this.startTimeLabel);
            this.createCaseFormPanel.Controls.Add(this.startTimeValue);
            this.createCaseFormPanel.Controls.Add(this.locationLabel);
            this.createCaseFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createCaseFormPanel.Location = new System.Drawing.Point(0, 0);
            this.createCaseFormPanel.Name = "createCaseFormPanel";
            this.createCaseFormPanel.Size = new System.Drawing.Size(978, 732);
            this.createCaseFormPanel.TabIndex = 12;
            this.createCaseFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // caseTypeValue
            // 
            this.caseTypeValue.FormattingEnabled = true;
            this.caseTypeValue.Location = new System.Drawing.Point(152, 417);
            this.caseTypeValue.Name = "caseTypeValue";
            this.caseTypeValue.Size = new System.Drawing.Size(140, 24);
            this.caseTypeValue.TabIndex = 13;
            // 
            // caseTypeLabel
            // 
            this.caseTypeLabel.AutoSize = true;
            this.caseTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.caseTypeLabel.Location = new System.Drawing.Point(59, 420);
            this.caseTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caseTypeLabel.Name = "caseTypeLabel";
            this.caseTypeLabel.Size = new System.Drawing.Size(80, 17);
            this.caseTypeLabel.TabIndex = 12;
            this.caseTypeLabel.Text = "Case Type:";
            // 
            // locationValue
            // 
            this.locationValue.FormattingEnabled = true;
            this.locationValue.Location = new System.Drawing.Point(152, 356);
            this.locationValue.Name = "locationValue";
            this.locationValue.Size = new System.Drawing.Size(287, 24);
            this.locationValue.TabIndex = 11;
            // 
            // CreateCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(978, 732);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.createCaseFormPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateCaseForm";
            this.Text = "CreateCaseForm";
            this.titlePanel.ResumeLayout(false);
            this.createCaseFormPanel.ResumeLayout(false);
            this.createCaseFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.DateTimePicker startTimeValue;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.DateTimePicker endDateValue;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker startDateValue;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Button createCaseButton;
        private System.Windows.Forms.Label caseNameLabel;
        private System.Windows.Forms.TextBox caseNameValue;
        private System.Windows.Forms.Panel createCaseFormPanel;
        private System.Windows.Forms.Label createCaseTitleLabel;
        private System.Windows.Forms.ComboBox caseTypeValue;
        private System.Windows.Forms.Label caseTypeLabel;
        private System.Windows.Forms.ComboBox locationValue;
    }
}