﻿
namespace Tyuiu.GoogeRA.Sprint7.Project0.V4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_GRA = new System.Windows.Forms.Panel();
            this.groupBoxFile_GRA = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile_GRA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GRA = new System.Windows.Forms.Button();
            this.panelMid_GRA = new System.Windows.Forms.Panel();
            this.groupBoxMid_GRA = new System.Windows.Forms.GroupBox();
            this.dataGridViewLB_GRA = new System.Windows.Forms.DataGridView();
            this.ColumnNameB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDrop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSrok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBot_GRA = new System.Windows.Forms.Panel();
            this.groupBoxCalcul_GRA = new System.Windows.Forms.GroupBox();
            this.groupBoxNumCol_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxNumColumn_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxRes = new System.Windows.Forms.GroupBox();
            this.textBoxSumCol_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxRed_GRA = new System.Windows.Forms.GroupBox();
            this.buttonSubtract_GRA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch_GRA = new System.Windows.Forms.TextBox();
            this.openFileDialogLB_GRA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogLB_GRA = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonAllB_GRA = new System.Windows.Forms.Button();
            this.buttonDel_GRA = new System.Windows.Forms.Button();
            this.buttonPS_GRA = new System.Windows.Forms.Button();
            this.buttonClear_GRA = new System.Windows.Forms.Button();
            this.buttonChart_GRA = new System.Windows.Forms.Button();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.buttonINFO_GRA = new System.Windows.Forms.Button();
            this.panelTop_GRA.SuspendLayout();
            this.groupBoxFile_GRA.SuspendLayout();
            this.panelMid_GRA.SuspendLayout();
            this.groupBoxMid_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLB_GRA)).BeginInit();
            this.panelBot_GRA.SuspendLayout();
            this.groupBoxCalcul_GRA.SuspendLayout();
            this.groupBoxNumCol_GRA.SuspendLayout();
            this.groupBoxRes.SuspendLayout();
            this.groupBoxRed_GRA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_GRA
            // 
            this.panelTop_GRA.Controls.Add(this.buttonChart_GRA);
            this.panelTop_GRA.Controls.Add(this.buttonHelp_GRA);
            this.panelTop_GRA.Controls.Add(this.groupBoxFile_GRA);
            this.panelTop_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GRA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GRA.Name = "panelTop_GRA";
            this.panelTop_GRA.Size = new System.Drawing.Size(848, 67);
            this.panelTop_GRA.TabIndex = 0;
            // 
            // groupBoxFile_GRA
            // 
            this.groupBoxFile_GRA.Controls.Add(this.buttonSaveFile_GRA);
            this.groupBoxFile_GRA.Controls.Add(this.buttonOpenFile_GRA);
            this.groupBoxFile_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFile_GRA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFile_GRA.Name = "groupBoxFile_GRA";
            this.groupBoxFile_GRA.Size = new System.Drawing.Size(173, 53);
            this.groupBoxFile_GRA.TabIndex = 0;
            this.groupBoxFile_GRA.TabStop = false;
            this.groupBoxFile_GRA.Text = "Файл";
            // 
            // buttonSaveFile_GRA
            // 
            this.buttonSaveFile_GRA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSaveFile_GRA.Enabled = false;
            this.buttonSaveFile_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_GRA.Location = new System.Drawing.Point(90, 17);
            this.buttonSaveFile_GRA.Name = "buttonSaveFile_GRA";
            this.buttonSaveFile_GRA.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile_GRA.TabIndex = 1;
            this.buttonSaveFile_GRA.Text = "Сохранить";
            this.buttonSaveFile_GRA.UseVisualStyleBackColor = false;
            this.buttonSaveFile_GRA.Click += new System.EventHandler(this.buttonSaveFile_GRA_Click);
            // 
            // buttonOpenFile_GRA
            // 
            this.buttonOpenFile_GRA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFile_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_GRA.Location = new System.Drawing.Point(8, 17);
            this.buttonOpenFile_GRA.Name = "buttonOpenFile_GRA";
            this.buttonOpenFile_GRA.Size = new System.Drawing.Size(75, 24);
            this.buttonOpenFile_GRA.TabIndex = 0;
            this.buttonOpenFile_GRA.Text = "Открыть";
            this.buttonOpenFile_GRA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_GRA.Click += new System.EventHandler(this.buttonOpenFile_GRA_Click);
            // 
            // panelMid_GRA
            // 
            this.panelMid_GRA.Controls.Add(this.groupBoxMid_GRA);
            this.panelMid_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid_GRA.Location = new System.Drawing.Point(0, 67);
            this.panelMid_GRA.Name = "panelMid_GRA";
            this.panelMid_GRA.Size = new System.Drawing.Size(848, 425);
            this.panelMid_GRA.TabIndex = 1;
            // 
            // groupBoxMid_GRA
            // 
            this.groupBoxMid_GRA.Controls.Add(this.dataGridViewLB_GRA);
            this.groupBoxMid_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMid_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMid_GRA.Name = "groupBoxMid_GRA";
            this.groupBoxMid_GRA.Size = new System.Drawing.Size(848, 425);
            this.groupBoxMid_GRA.TabIndex = 0;
            this.groupBoxMid_GRA.TabStop = false;
            this.groupBoxMid_GRA.Text = "Таблица";
            // 
            // dataGridViewLB_GRA
            // 
            this.dataGridViewLB_GRA.AllowUserToOrderColumns = true;
            this.dataGridViewLB_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLB_GRA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameB,
            this.ColumnAutor,
            this.ColumnEars,
            this.ColumnIZ,
            this.ColumnCopy,
            this.ColumnDrop,
            this.ColumnOst,
            this.ColumnSrok});
            this.dataGridViewLB_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLB_GRA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLB_GRA.Name = "dataGridViewLB_GRA";
            this.dataGridViewLB_GRA.Size = new System.Drawing.Size(842, 406);
            this.dataGridViewLB_GRA.TabIndex = 0;
            this.dataGridViewLB_GRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLB_GRA_CellContentClick);
            // 
            // ColumnNameB
            // 
            this.ColumnNameB.HeaderText = "Название книги";
            this.ColumnNameB.Name = "ColumnNameB";
            // 
            // ColumnAutor
            // 
            this.ColumnAutor.HeaderText = "Автор";
            this.ColumnAutor.Name = "ColumnAutor";
            // 
            // ColumnEars
            // 
            this.ColumnEars.HeaderText = "Год выпусска";
            this.ColumnEars.Name = "ColumnEars";
            // 
            // ColumnIZ
            // 
            this.ColumnIZ.HeaderText = "Издание";
            this.ColumnIZ.Name = "ColumnIZ";
            // 
            // ColumnCopy
            // 
            this.ColumnCopy.HeaderText = "Копии";
            this.ColumnCopy.Name = "ColumnCopy";
            // 
            // ColumnDrop
            // 
            this.ColumnDrop.HeaderText = "Выданно";
            this.ColumnDrop.Name = "ColumnDrop";
            // 
            // ColumnOst
            // 
            this.ColumnOst.HeaderText = "Наличие";
            this.ColumnOst.Name = "ColumnOst";
            // 
            // ColumnSrok
            // 
            this.ColumnSrok.HeaderText = "Просроченно";
            this.ColumnSrok.MinimumWidth = 12;
            this.ColumnSrok.Name = "ColumnSrok";
            // 
            // panelBot_GRA
            // 
            this.panelBot_GRA.Controls.Add(this.buttonINFO_GRA);
            this.panelBot_GRA.Controls.Add(this.groupBoxCalcul_GRA);
            this.panelBot_GRA.Controls.Add(this.groupBoxRed_GRA);
            this.panelBot_GRA.Controls.Add(this.groupBox1);
            this.panelBot_GRA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot_GRA.Location = new System.Drawing.Point(0, 377);
            this.panelBot_GRA.Name = "panelBot_GRA";
            this.panelBot_GRA.Size = new System.Drawing.Size(848, 115);
            this.panelBot_GRA.TabIndex = 2;
            // 
            // groupBoxCalcul_GRA
            // 
            this.groupBoxCalcul_GRA.Controls.Add(this.groupBoxNumCol_GRA);
            this.groupBoxCalcul_GRA.Controls.Add(this.groupBoxRes);
            this.groupBoxCalcul_GRA.Controls.Add(this.buttonAllB_GRA);
            this.groupBoxCalcul_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCalcul_GRA.Location = new System.Drawing.Point(165, 4);
            this.groupBoxCalcul_GRA.Name = "groupBoxCalcul_GRA";
            this.groupBoxCalcul_GRA.Size = new System.Drawing.Size(278, 105);
            this.groupBoxCalcul_GRA.TabIndex = 5;
            this.groupBoxCalcul_GRA.TabStop = false;
            this.groupBoxCalcul_GRA.Text = "Калькулятор";
            // 
            // groupBoxNumCol_GRA
            // 
            this.groupBoxNumCol_GRA.Controls.Add(this.textBoxNumColumn_GRA);
            this.groupBoxNumCol_GRA.Location = new System.Drawing.Point(6, 12);
            this.groupBoxNumCol_GRA.Name = "groupBoxNumCol_GRA";
            this.groupBoxNumCol_GRA.Size = new System.Drawing.Size(62, 45);
            this.groupBoxNumCol_GRA.TabIndex = 6;
            this.groupBoxNumCol_GRA.TabStop = false;
            this.groupBoxNumCol_GRA.Text = "IndexC";
            // 
            // textBoxNumColumn_GRA
            // 
            this.textBoxNumColumn_GRA.Location = new System.Drawing.Point(6, 17);
            this.textBoxNumColumn_GRA.Name = "textBoxNumColumn_GRA";
            this.textBoxNumColumn_GRA.Size = new System.Drawing.Size(45, 20);
            this.textBoxNumColumn_GRA.TabIndex = 4;
            // 
            // groupBoxRes
            // 
            this.groupBoxRes.Controls.Add(this.textBoxSumCol_GRA);
            this.groupBoxRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxRes.Location = new System.Drawing.Point(74, 12);
            this.groupBoxRes.Name = "groupBoxRes";
            this.groupBoxRes.Size = new System.Drawing.Size(74, 45);
            this.groupBoxRes.TabIndex = 5;
            this.groupBoxRes.TabStop = false;
            this.groupBoxRes.Text = "Результат";
            // 
            // textBoxSumCol_GRA
            // 
            this.textBoxSumCol_GRA.Location = new System.Drawing.Point(6, 17);
            this.textBoxSumCol_GRA.Name = "textBoxSumCol_GRA";
            this.textBoxSumCol_GRA.Size = new System.Drawing.Size(58, 20);
            this.textBoxSumCol_GRA.TabIndex = 4;
            // 
            // groupBoxRed_GRA
            // 
            this.groupBoxRed_GRA.Controls.Add(this.buttonSubtract_GRA);
            this.groupBoxRed_GRA.Controls.Add(this.buttonDel_GRA);
            this.groupBoxRed_GRA.Controls.Add(this.buttonPS_GRA);
            this.groupBoxRed_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxRed_GRA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxRed_GRA.Name = "groupBoxRed_GRA";
            this.groupBoxRed_GRA.Size = new System.Drawing.Size(155, 108);
            this.groupBoxRed_GRA.TabIndex = 1;
            this.groupBoxRed_GRA.TabStop = false;
            this.groupBoxRed_GRA.Text = "Редактирование таблицы";
            // 
            // buttonSubtract_GRA
            // 
            this.buttonSubtract_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract_GRA.Location = new System.Drawing.Point(46, 69);
            this.buttonSubtract_GRA.Name = "buttonSubtract_GRA";
            this.buttonSubtract_GRA.Size = new System.Drawing.Size(61, 24);
            this.buttonSubtract_GRA.TabIndex = 2;
            this.buttonSubtract_GRA.Text = "Остаток";
            this.buttonSubtract_GRA.UseVisualStyleBackColor = true;
            this.buttonSubtract_GRA.Click += new System.EventHandler(this.buttonSubtract_GRA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonClear_GRA);
            this.groupBox1.Controls.Add(this.textBoxSearch_GRA);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(449, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // textBoxSearch_GRA
            // 
            this.textBoxSearch_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_GRA.Location = new System.Drawing.Point(7, 16);
            this.textBoxSearch_GRA.Name = "textBoxSearch_GRA";
            this.textBoxSearch_GRA.Size = new System.Drawing.Size(337, 20);
            this.textBoxSearch_GRA.TabIndex = 0;
            this.textBoxSearch_GRA.TextChanged += new System.EventHandler(this.textBoxSearch_GRA_TextChanged);
            // 
            // openFileDialogLB_GRA
            // 
            this.openFileDialogLB_GRA.FileName = "openFileDialogLB_GRA";
            // 
            // saveFileDialogLB_GRA
            // 
            this.saveFileDialogLB_GRA.FileName = "saveFileDialogLB_GRA";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // buttonAllB_GRA
            // 
            this.buttonAllB_GRA.BackColor = System.Drawing.Color.White;
            this.buttonAllB_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllB_GRA.Image = ((System.Drawing.Image)(resources.GetObject("buttonAllB_GRA.Image")));
            this.buttonAllB_GRA.Location = new System.Drawing.Point(6, 63);
            this.buttonAllB_GRA.Name = "buttonAllB_GRA";
            this.buttonAllB_GRA.Size = new System.Drawing.Size(62, 36);
            this.buttonAllB_GRA.TabIndex = 3;
            this.buttonAllB_GRA.UseVisualStyleBackColor = false;
            this.buttonAllB_GRA.Click += new System.EventHandler(this.buttonAllB_GRA_Click);
            // 
            // buttonDel_GRA
            // 
            this.buttonDel_GRA.BackColor = System.Drawing.Color.White;
            this.buttonDel_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel_GRA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDel_GRA.Image")));
            this.buttonDel_GRA.Location = new System.Drawing.Point(85, 18);
            this.buttonDel_GRA.Name = "buttonDel_GRA";
            this.buttonDel_GRA.Size = new System.Drawing.Size(64, 45);
            this.buttonDel_GRA.TabIndex = 1;
            this.buttonDel_GRA.UseVisualStyleBackColor = false;
            this.buttonDel_GRA.Click += new System.EventHandler(this.buttonDel_GRA_Click);
            // 
            // buttonPS_GRA
            // 
            this.buttonPS_GRA.BackColor = System.Drawing.Color.White;
            this.buttonPS_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPS_GRA.Image = ((System.Drawing.Image)(resources.GetObject("buttonPS_GRA.Image")));
            this.buttonPS_GRA.Location = new System.Drawing.Point(9, 19);
            this.buttonPS_GRA.Name = "buttonPS_GRA";
            this.buttonPS_GRA.Size = new System.Drawing.Size(61, 44);
            this.buttonPS_GRA.TabIndex = 0;
            this.buttonPS_GRA.UseVisualStyleBackColor = false;
            this.buttonPS_GRA.Click += new System.EventHandler(this.buttonPS_GRA_Click);
            // 
            // buttonClear_GRA
            // 
            this.buttonClear_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear_GRA.BackColor = System.Drawing.Color.White;
            this.buttonClear_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear_GRA.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear_GRA.Image")));
            this.buttonClear_GRA.Location = new System.Drawing.Point(350, 12);
            this.buttonClear_GRA.Name = "buttonClear_GRA";
            this.buttonClear_GRA.Size = new System.Drawing.Size(31, 31);
            this.buttonClear_GRA.TabIndex = 1;
            this.buttonClear_GRA.UseVisualStyleBackColor = false;
            this.buttonClear_GRA.Click += new System.EventHandler(this.buttonClear_GRA_Click);
            // 
            // buttonChart_GRA
            // 
            this.buttonChart_GRA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChart_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChart_GRA.Image = ((System.Drawing.Image)(resources.GetObject("buttonChart_GRA.Image")));
            this.buttonChart_GRA.Location = new System.Drawing.Point(183, 10);
            this.buttonChart_GRA.Name = "buttonChart_GRA";
            this.buttonChart_GRA.Size = new System.Drawing.Size(74, 51);
            this.buttonChart_GRA.TabIndex = 2;
            this.buttonChart_GRA.UseVisualStyleBackColor = false;
            this.buttonChart_GRA.Click += new System.EventHandler(this.buttonChart_GRA_Click);
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GRA.BackColor = System.Drawing.Color.White;
            this.buttonHelp_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_GRA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_GRA.Image")));
            this.buttonHelp_GRA.Location = new System.Drawing.Point(762, 7);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(74, 51);
            this.buttonHelp_GRA.TabIndex = 1;
            this.buttonHelp_GRA.UseVisualStyleBackColor = false;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // buttonINFO_GRA
            // 
            this.buttonINFO_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonINFO_GRA.Image = ((System.Drawing.Image)(resources.GetObject("buttonINFO_GRA.Image")));
            this.buttonINFO_GRA.Location = new System.Drawing.Point(787, 59);
            this.buttonINFO_GRA.Name = "buttonINFO_GRA";
            this.buttonINFO_GRA.Size = new System.Drawing.Size(50, 47);
            this.buttonINFO_GRA.TabIndex = 6;
            this.buttonINFO_GRA.UseVisualStyleBackColor = true;
            this.buttonINFO_GRA.Click += new System.EventHandler(this.buttonINFO_GRA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(848, 492);
            this.Controls.Add(this.panelBot_GRA);
            this.Controls.Add(this.panelMid_GRA);
            this.Controls.Add(this.panelTop_GRA);
            this.MinimumSize = new System.Drawing.Size(864, 531);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_GRA.ResumeLayout(false);
            this.groupBoxFile_GRA.ResumeLayout(false);
            this.panelMid_GRA.ResumeLayout(false);
            this.groupBoxMid_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLB_GRA)).EndInit();
            this.panelBot_GRA.ResumeLayout(false);
            this.groupBoxCalcul_GRA.ResumeLayout(false);
            this.groupBoxNumCol_GRA.ResumeLayout(false);
            this.groupBoxNumCol_GRA.PerformLayout();
            this.groupBoxRes.ResumeLayout(false);
            this.groupBoxRes.PerformLayout();
            this.groupBoxRed_GRA.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_GRA;
        private System.Windows.Forms.GroupBox groupBoxFile_GRA;
        private System.Windows.Forms.Button buttonSaveFile_GRA;
        private System.Windows.Forms.Button buttonOpenFile_GRA;
        private System.Windows.Forms.Panel panelMid_GRA;
        private System.Windows.Forms.DataGridView dataGridViewLB_GRA;
        private System.Windows.Forms.Panel panelBot_GRA;
        private System.Windows.Forms.GroupBox groupBoxRed_GRA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialogLB_GRA;
        private System.Windows.Forms.OpenFileDialog saveFileDialogLB_GRA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonClear_GRA;
        private System.Windows.Forms.TextBox textBoxSearch_GRA;
        private System.Windows.Forms.Button buttonPS_GRA;
        private System.Windows.Forms.Button buttonDel_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.Button buttonSubtract_GRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEars;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDrop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSrok;
        private System.Windows.Forms.GroupBox groupBoxMid_GRA;
        private System.Windows.Forms.TextBox textBoxSumCol_GRA;
        private System.Windows.Forms.Button buttonAllB_GRA;
        private System.Windows.Forms.GroupBox groupBoxCalcul_GRA;
        private System.Windows.Forms.GroupBox groupBoxRes;
        private System.Windows.Forms.TextBox textBoxNumColumn_GRA;
        private System.Windows.Forms.GroupBox groupBoxNumCol_GRA;
        private System.Windows.Forms.Button buttonChart_GRA;
        private System.Windows.Forms.Button buttonINFO_GRA;
    }
}

