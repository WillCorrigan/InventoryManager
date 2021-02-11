
namespace InventoryManagerUI
{
    partial class ViewEditCaseForm
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
            this.caseNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caseNameLabel
            // 
            this.caseNameLabel.ForeColor = System.Drawing.Color.White;
            this.caseNameLabel.Location = new System.Drawing.Point(341, 183);
            this.caseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caseNameLabel.Name = "caseNameLabel";
            this.caseNameLabel.Size = new System.Drawing.Size(256, 80);
            this.caseNameLabel.TabIndex = 0;
            this.caseNameLabel.Text = "CaseName";
            // 
            // ViewEditCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(978, 732);
            this.Controls.Add(this.caseNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewEditCaseForm";
            this.Text = "ViewEditCaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label caseNameLabel;
    }
}