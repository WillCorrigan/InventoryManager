
namespace InventoryManagerUI
{
    partial class ViewAllCasesForm
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
            this.viewAllCasesTitleLabel = new System.Windows.Forms.Label();
            this.viewAllCasesFormPanel = new System.Windows.Forms.Panel();
            this.allCasesList = new System.Windows.Forms.ListView();
            this.getAllButton = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            this.viewAllCasesFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.viewAllCasesTitleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(978, 97);
            this.titlePanel.TabIndex = 12;
            // 
            // viewAllCasesTitleLabel
            // 
            this.viewAllCasesTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAllCasesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.viewAllCasesTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewAllCasesTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.viewAllCasesTitleLabel.Name = "viewAllCasesTitleLabel";
            this.viewAllCasesTitleLabel.Size = new System.Drawing.Size(978, 97);
            this.viewAllCasesTitleLabel.TabIndex = 0;
            this.viewAllCasesTitleLabel.Text = "All Cases";
            this.viewAllCasesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewAllCasesFormPanel
            // 
            this.viewAllCasesFormPanel.Controls.Add(this.getAllButton);
            this.viewAllCasesFormPanel.Controls.Add(this.allCasesList);
            this.viewAllCasesFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAllCasesFormPanel.Location = new System.Drawing.Point(0, 97);
            this.viewAllCasesFormPanel.Name = "viewAllCasesFormPanel";
            this.viewAllCasesFormPanel.Size = new System.Drawing.Size(978, 635);
            this.viewAllCasesFormPanel.TabIndex = 13;
            // 
            // allCasesList
            // 
            this.allCasesList.BackColor = System.Drawing.SystemColors.Window;
            this.allCasesList.FullRowSelect = true;
            this.allCasesList.GridLines = true;
            this.allCasesList.HideSelection = false;
            this.allCasesList.Location = new System.Drawing.Point(36, 27);
            this.allCasesList.Name = "allCasesList";
            this.allCasesList.Size = new System.Drawing.Size(896, 439);
            this.allCasesList.TabIndex = 0;
            this.allCasesList.UseCompatibleStateImageBehavior = false;
            this.allCasesList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // getAllButton
            // 
            this.getAllButton.Location = new System.Drawing.Point(438, 540);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(75, 23);
            this.getAllButton.TabIndex = 1;
            this.getAllButton.Text = "View All";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
            // 
            // ViewAllCasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(978, 732);
            this.Controls.Add(this.viewAllCasesFormPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAllCasesForm";
            this.Text = "ViewAllCasesForm";
            this.titlePanel.ResumeLayout(false);
            this.viewAllCasesFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label viewAllCasesTitleLabel;
        private System.Windows.Forms.Panel viewAllCasesFormPanel;
        private System.Windows.Forms.ListView allCasesList;
        private System.Windows.Forms.Button getAllButton;
    }
}