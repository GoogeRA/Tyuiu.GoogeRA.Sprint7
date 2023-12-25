
namespace Tyuiu.GoogeRA.Sprint7.Project0.V4
{
    partial class FormAboutGraf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRes_GRA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxRes_GRA = new System.Windows.Forms.GroupBox();
            this.buttonRes_GRA = new System.Windows.Forms.Button();
            this.buttonOK_GRA = new System.Windows.Forms.Button();
            this.groupBoxIndex_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxIndexCol_GRA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_GRA)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxRes_GRA.SuspendLayout();
            this.groupBoxIndex_GRA.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartRes_GRA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes_GRA.ChartAreas.Add(chartArea1);
            this.chartRes_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartRes_GRA.Legends.Add(legend1);
            this.chartRes_GRA.Location = new System.Drawing.Point(3, 16);
            this.chartRes_GRA.Name = "chartRes_GRA";
            this.chartRes_GRA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes_GRA.Series.Add(series1);
            this.chartRes_GRA.Size = new System.Drawing.Size(574, 284);
            this.chartRes_GRA.TabIndex = 0;
            this.chartRes_GRA.Text = "chart1";
            this.chartRes_GRA.Click += new System.EventHandler(this.chartFrom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxRes_GRA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 356);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxRes_GRA
            // 
            this.groupBoxRes_GRA.Controls.Add(this.chartRes_GRA);
            this.groupBoxRes_GRA.Controls.Add(this.groupBoxIndex_GRA);
            this.groupBoxRes_GRA.Controls.Add(this.buttonOK_GRA);
            this.groupBoxRes_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_GRA.Name = "groupBoxRes_GRA";
            this.groupBoxRes_GRA.Size = new System.Drawing.Size(580, 356);
            this.groupBoxRes_GRA.TabIndex = 2;
            this.groupBoxRes_GRA.TabStop = false;
            // 
            // buttonRes_GRA
            // 
            this.buttonRes_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRes_GRA.Location = new System.Drawing.Point(127, 14);
            this.buttonRes_GRA.Name = "buttonRes_GRA";
            this.buttonRes_GRA.Size = new System.Drawing.Size(98, 30);
            this.buttonRes_GRA.TabIndex = 1;
            this.buttonRes_GRA.Text = "Выполнить";
            this.buttonRes_GRA.UseVisualStyleBackColor = true;
            this.buttonRes_GRA.Click += new System.EventHandler(this.buttonRes_GRA_Click);
            // 
            // buttonOK_GRA
            // 
            this.buttonOK_GRA.BackColor = System.Drawing.Color.White;
            this.buttonOK_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK_GRA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOK_GRA.Location = new System.Drawing.Point(456, 306);
            this.buttonOK_GRA.Name = "buttonOK_GRA";
            this.buttonOK_GRA.Size = new System.Drawing.Size(106, 30);
            this.buttonOK_GRA.TabIndex = 0;
            this.buttonOK_GRA.Text = "ОК";
            this.buttonOK_GRA.UseVisualStyleBackColor = false;
            this.buttonOK_GRA.Click += new System.EventHandler(this.buttonOK_GRA_Click);
            // 
            // groupBoxIndex_GRA
            // 
            this.groupBoxIndex_GRA.Controls.Add(this.textBoxIndexCol_GRA);
            this.groupBoxIndex_GRA.Controls.Add(this.buttonRes_GRA);
            this.groupBoxIndex_GRA.Location = new System.Drawing.Point(6, 300);
            this.groupBoxIndex_GRA.Name = "groupBoxIndex_GRA";
            this.groupBoxIndex_GRA.Size = new System.Drawing.Size(231, 50);
            this.groupBoxIndex_GRA.TabIndex = 2;
            this.groupBoxIndex_GRA.TabStop = false;
            this.groupBoxIndex_GRA.Text = "Номер столбца";
            // 
            // textBoxIndexCol_GRA
            // 
            this.textBoxIndexCol_GRA.Location = new System.Drawing.Point(7, 20);
            this.textBoxIndexCol_GRA.Name = "textBoxIndexCol_GRA";
            this.textBoxIndexCol_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndexCol_GRA.TabIndex = 0;
            this.textBoxIndexCol_GRA.TextChanged += new System.EventHandler(this.textBoxIndexCol_GRA_TextChanged);
            // 
            // FormAboutGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 356);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(596, 395);
            this.MinimumSize = new System.Drawing.Size(596, 395);
            this.Name = "FormAboutGraf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_GRA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxRes_GRA.ResumeLayout(false);
            this.groupBoxIndex_GRA.ResumeLayout(false);
            this.groupBoxIndex_GRA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_GRA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxRes_GRA;
        private System.Windows.Forms.Button buttonOK_GRA;
        private System.Windows.Forms.Button buttonRes_GRA;
        private System.Windows.Forms.GroupBox groupBoxIndex_GRA;
        private System.Windows.Forms.TextBox textBoxIndexCol_GRA;
    }
}