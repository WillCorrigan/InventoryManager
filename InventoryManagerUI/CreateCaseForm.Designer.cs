
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.locationValue = new System.Windows.Forms.ComboBox();
            this.caseTypeLabel = new System.Windows.Forms.Label();
            this.caseTypeValue = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 97);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(305, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Create Case";
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
            this.startTimeValue.Value = new System.DateTime(2021, 2, 3, 14, 23, 0, 0);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.caseTypeValue);
            this.panel2.Controls.Add(this.caseTypeLabel);
            this.panel2.Controls.Add(this.locationValue);
            this.panel2.Controls.Add(this.caseNameValue);
            this.panel2.Controls.Add(this.caseNameLabel);
            this.panel2.Controls.Add(this.createCaseButton);
            this.panel2.Controls.Add(this.startDateLabel);
            this.panel2.Controls.Add(this.startDateValue);
            this.panel2.Controls.Add(this.endDateLabel);
            this.panel2.Controls.Add(this.endDateValue);
            this.panel2.Controls.Add(this.startTimeLabel);
            this.panel2.Controls.Add(this.startTimeValue);
            this.panel2.Controls.Add(this.locationLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 560);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // locationValue
            // 
            this.locationValue.FormattingEnabled = true;
            this.locationValue.Location = new System.Drawing.Point(152, 356);
            this.locationValue.Name = "locationValue";
            this.locationValue.Size = new System.Drawing.Size(287, 24);
            this.locationValue.TabIndex = 11;
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
            // caseTypeValue
            // 
            this.caseTypeValue.FormattingEnabled = true;
            this.caseTypeValue.Location = new System.Drawing.Point(152, 417);
            this.caseTypeValue.Name = "caseTypeValue";
            this.caseTypeValue.Size = new System.Drawing.Size(140, 24);
            this.caseTypeValue.TabIndex = 13;
            // 
            // CreateCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(869, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateCaseForm";
            this.Text = "CreateCaseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox caseTypeValue;
        private System.Windows.Forms.Label caseTypeLabel;
        private System.Windows.Forms.ComboBox locationValue;
    }
}