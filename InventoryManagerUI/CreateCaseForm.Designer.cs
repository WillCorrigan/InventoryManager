
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
            this.createCaseLabel = new System.Windows.Forms.Label();
            this.caseNameValue = new System.Windows.Forms.TextBox();
            this.createCaseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createCaseLabel
            // 
            this.createCaseLabel.AutoSize = true;
            this.createCaseLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createCaseLabel.Location = new System.Drawing.Point(127, 63);
            this.createCaseLabel.Name = "createCaseLabel";
            this.createCaseLabel.Size = new System.Drawing.Size(65, 13);
            this.createCaseLabel.TabIndex = 0;
            this.createCaseLabel.Text = "Case Name:";
            // 
            // caseNameValue
            // 
            this.caseNameValue.Location = new System.Drawing.Point(216, 56);
            this.caseNameValue.Name = "caseNameValue";
            this.caseNameValue.Size = new System.Drawing.Size(216, 20);
            this.caseNameValue.TabIndex = 1;
            this.caseNameValue.TextChanged += new System.EventHandler(this.caseNameValue_TextChanged);
            // 
            // createCaseButton
            // 
            this.createCaseButton.Location = new System.Drawing.Point(375, 302);
            this.createCaseButton.Name = "createCaseButton";
            this.createCaseButton.Size = new System.Drawing.Size(75, 23);
            this.createCaseButton.TabIndex = 2;
            this.createCaseButton.Text = "Create Case";
            this.createCaseButton.UseVisualStyleBackColor = true;
            this.createCaseButton.Click += new System.EventHandler(this.createCaseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(127, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date:";
            // 
            // CreateCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1039, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createCaseButton);
            this.Controls.Add(this.caseNameValue);
            this.Controls.Add(this.createCaseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateCaseForm";
            this.Text = "CreateCaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createCaseLabel;
        private System.Windows.Forms.TextBox caseNameValue;
        private System.Windows.Forms.Button createCaseButton;
        private System.Windows.Forms.Label label1;
    }
}