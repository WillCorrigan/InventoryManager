
namespace InventoryManagerUI
{
    partial class createCaseForm
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
            this.createCaseButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.caseNameValue = new System.Windows.Forms.TextBox();
            this.startDateValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createCaseButton
            // 
            this.createCaseButton.Location = new System.Drawing.Point(246, 420);
            this.createCaseButton.Name = "createCaseButton";
            this.createCaseButton.Size = new System.Drawing.Size(278, 79);
            this.createCaseButton.TabIndex = 2;
            this.createCaseButton.Text = "Create Case";
            this.createCaseButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(207, 50);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Case Name:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(12, 163);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(185, 50);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date:";
            // 
            // caseNameValue
            // 
            this.caseNameValue.Location = new System.Drawing.Point(225, 93);
            this.caseNameValue.Name = "caseNameValue";
            this.caseNameValue.Size = new System.Drawing.Size(330, 35);
            this.caseNameValue.TabIndex = 5;
            this.caseNameValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // startDateValue
            // 
            this.startDateValue.Location = new System.Drawing.Point(225, 176);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(330, 35);
            this.startDateValue.TabIndex = 6;
            // 
            // createCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 560);
            this.Controls.Add(this.startDateValue);
            this.Controls.Add(this.caseNameValue);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createCaseButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "createCaseForm";
            this.Text = "Create Case";
            this.Load += new System.EventHandler(this.CaseViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createCaseButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TextBox caseNameValue;
        private System.Windows.Forms.TextBox startDateValue;
    }
}

