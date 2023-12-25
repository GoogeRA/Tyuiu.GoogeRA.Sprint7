
namespace Tyuiu.GoogeRA.Sprint7.Project0.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_GRA = new System.Windows.Forms.Button();
            this.labelHelp_GRA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK_GRA
            // 
            this.buttonOK_GRA.Location = new System.Drawing.Point(107, 129);
            this.buttonOK_GRA.Name = "buttonOK_GRA";
            this.buttonOK_GRA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_GRA.TabIndex = 0;
            this.buttonOK_GRA.Text = "ОК";
            this.buttonOK_GRA.UseVisualStyleBackColor = true;
            this.buttonOK_GRA.Click += new System.EventHandler(this.buttonOK_GRA_Click);
            // 
            // labelHelp_GRA
            // 
            this.labelHelp_GRA.AutoSize = true;
            this.labelHelp_GRA.Location = new System.Drawing.Point(23, 20);
            this.labelHelp_GRA.Name = "labelHelp_GRA";
            this.labelHelp_GRA.Size = new System.Drawing.Size(242, 91);
            this.labelHelp_GRA.TabIndex = 1;
            this.labelHelp_GRA.Text = resources.GetString("labelHelp_GRA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 166);
            this.Controls.Add(this.labelHelp_GRA);
            this.Controls.Add(this.buttonOK_GRA);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поддержка";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_GRA;
        private System.Windows.Forms.Label labelHelp_GRA;
    }
}