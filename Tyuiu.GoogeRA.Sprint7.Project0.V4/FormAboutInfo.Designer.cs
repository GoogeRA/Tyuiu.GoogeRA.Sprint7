
namespace Tyuiu.GoogeRA.Sprint7.Project0.V4
{
    partial class FormAboutInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutInfo));
            this.buttonOK_GRA = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_GRA = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_GRA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_GRA
            // 
            this.buttonOK_GRA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK_GRA.Location = new System.Drawing.Point(350, 147);
            this.buttonOK_GRA.Name = "buttonOK_GRA";
            this.buttonOK_GRA.Size = new System.Drawing.Size(80, 25);
            this.buttonOK_GRA.TabIndex = 0;
            this.buttonOK_GRA.Text = "OK";
            this.buttonOK_GRA.UseVisualStyleBackColor = false;
            this.buttonOK_GRA.Click += new System.EventHandler(this.buttonOK_GRA_Click);
            // 
            // pictureBoxAvatar_GRA
            // 
            this.pictureBoxAvatar_GRA.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxAvatar_GRA.Image = global::Tyuiu.GoogeRA.Sprint7.Project0.V4.Properties.Resources._1_83408_128;
            this.pictureBoxAvatar_GRA.Location = new System.Drawing.Point(14, 9);
            this.pictureBoxAvatar_GRA.Name = "pictureBoxAvatar_GRA";
            this.pictureBoxAvatar_GRA.Size = new System.Drawing.Size(123, 130);
            this.pictureBoxAvatar_GRA.TabIndex = 1;
            this.pictureBoxAvatar_GRA.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 130);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormAboutInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAvatar_GRA);
            this.Controls.Add(this.buttonOK_GRA);
            this.MaximumSize = new System.Drawing.Size(458, 223);
            this.MinimumSize = new System.Drawing.Size(458, 223);
            this.Name = "FormAboutInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Разработчик";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_GRA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_GRA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_GRA;
        private System.Windows.Forms.Label label1;
    }
}