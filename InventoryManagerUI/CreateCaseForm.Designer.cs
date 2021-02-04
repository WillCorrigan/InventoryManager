
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startTimeValue = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.endDateValue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateValue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.createCaseButton = new System.Windows.Forms.Button();
            this.createCaseLabel = new System.Windows.Forms.Label();
            this.caseNameValue = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(59, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Time:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(59, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Time:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(59, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date:";
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
            // createCaseLabel
            // 
            this.createCaseLabel.AutoSize = true;
            this.createCaseLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createCaseLabel.Location = new System.Drawing.Point(59, 171);
            this.createCaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createCaseLabel.Name = "createCaseLabel";
            this.createCaseLabel.Size = new System.Drawing.Size(85, 17);
            this.createCaseLabel.TabIndex = 0;
            this.createCaseLabel.Text = "Case Name:";
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
            this.panel2.Controls.Add(this.caseNameValue);
            this.panel2.Controls.Add(this.createCaseLabel);
            this.panel2.Controls.Add(this.createCaseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.startDateValue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.endDateValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.startTimeValue);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 560);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker startTimeValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDateValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDateValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createCaseButton;
        private System.Windows.Forms.Label createCaseLabel;
        private System.Windows.Forms.TextBox caseNameValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}