
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
            this.panelTop_GRA = new System.Windows.Forms.Panel();
            this.groupBoxFile_GRA = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile_GRA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GRA = new System.Windows.Forms.Button();
            this.panelMid_GRA = new System.Windows.Forms.Panel();
            this.dataGridViewLB_GRA = new System.Windows.Forms.DataGridView();
            this.panelBot_GRA = new System.Windows.Forms.Panel();
            this.groupBoxRed_GRA = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialogLB_GRA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogLB_GRA = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxSearch_GRA = new System.Windows.Forms.TextBox();
            this.buttonClear_GRA = new System.Windows.Forms.Button();
            this.buttonPS_GRA = new System.Windows.Forms.Button();
            this.buttonDel_GRA = new System.Windows.Forms.Button();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.buttonSubtract_GRA = new System.Windows.Forms.Button();
            this.ColumnNameB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDrop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSrok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMid_GRA = new System.Windows.Forms.GroupBox();
            this.panelTop_GRA.SuspendLayout();
            this.groupBoxFile_GRA.SuspendLayout();
            this.panelMid_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLB_GRA)).BeginInit();
            this.panelBot_GRA.SuspendLayout();
            this.groupBoxRed_GRA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMid_GRA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_GRA
            // 
            this.panelTop_GRA.Controls.Add(this.buttonHelp_GRA);
            this.panelTop_GRA.Controls.Add(this.groupBoxFile_GRA);
            this.panelTop_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GRA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GRA.Name = "panelTop_GRA";
            this.panelTop_GRA.Size = new System.Drawing.Size(842, 57);
            this.panelTop_GRA.TabIndex = 0;
            // 
            // groupBoxFile_GRA
            // 
            this.groupBoxFile_GRA.Controls.Add(this.buttonSaveFile_GRA);
            this.groupBoxFile_GRA.Controls.Add(this.buttonOpenFile_GRA);
            this.groupBoxFile_GRA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFile_GRA.Name = "groupBoxFile_GRA";
            this.groupBoxFile_GRA.Size = new System.Drawing.Size(173, 47);
            this.groupBoxFile_GRA.TabIndex = 0;
            this.groupBoxFile_GRA.TabStop = false;
            this.groupBoxFile_GRA.Text = "Файл";
            // 
            // buttonSaveFile_GRA
            // 
            this.buttonSaveFile_GRA.Location = new System.Drawing.Point(90, 17);
            this.buttonSaveFile_GRA.Name = "buttonSaveFile_GRA";
            this.buttonSaveFile_GRA.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile_GRA.TabIndex = 1;
            this.buttonSaveFile_GRA.Text = "Сохранить";
            this.buttonSaveFile_GRA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_GRA.Click += new System.EventHandler(this.buttonSaveFile_GRA_Click);
            // 
            // buttonOpenFile_GRA
            // 
            this.buttonOpenFile_GRA.Location = new System.Drawing.Point(8, 17);
            this.buttonOpenFile_GRA.Name = "buttonOpenFile_GRA";
            this.buttonOpenFile_GRA.Size = new System.Drawing.Size(75, 24);
            this.buttonOpenFile_GRA.TabIndex = 0;
            this.buttonOpenFile_GRA.Text = "Открыть";
            this.buttonOpenFile_GRA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GRA.Click += new System.EventHandler(this.buttonOpenFile_GRA_Click);
            // 
            // panelMid_GRA
            // 
            this.panelMid_GRA.Controls.Add(this.groupBoxMid_GRA);
            this.panelMid_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid_GRA.Location = new System.Drawing.Point(0, 57);
            this.panelMid_GRA.Name = "panelMid_GRA";
            this.panelMid_GRA.Size = new System.Drawing.Size(842, 393);
            this.panelMid_GRA.TabIndex = 1;
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
            this.dataGridViewLB_GRA.Size = new System.Drawing.Size(836, 374);
            this.dataGridViewLB_GRA.TabIndex = 0;
            this.dataGridViewLB_GRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLB_GRA_CellContentClick);
            // 
            // panelBot_GRA
            // 
            this.panelBot_GRA.Controls.Add(this.groupBoxRed_GRA);
            this.panelBot_GRA.Controls.Add(this.groupBox1);
            this.panelBot_GRA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot_GRA.Location = new System.Drawing.Point(0, 350);
            this.panelBot_GRA.Name = "panelBot_GRA";
            this.panelBot_GRA.Size = new System.Drawing.Size(842, 100);
            this.panelBot_GRA.TabIndex = 2;
            // 
            // groupBoxRed_GRA
            // 
            this.groupBoxRed_GRA.Controls.Add(this.buttonSubtract_GRA);
            this.groupBoxRed_GRA.Controls.Add(this.buttonDel_GRA);
            this.groupBoxRed_GRA.Controls.Add(this.buttonPS_GRA);
            this.groupBoxRed_GRA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxRed_GRA.Name = "groupBoxRed_GRA";
            this.groupBoxRed_GRA.Size = new System.Drawing.Size(226, 84);
            this.groupBoxRed_GRA.TabIndex = 1;
            this.groupBoxRed_GRA.TabStop = false;
            this.groupBoxRed_GRA.Text = "Редактирование таблицы";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonClear_GRA);
            this.groupBox1.Controls.Add(this.textBoxSearch_GRA);
            this.groupBox1.Location = new System.Drawing.Point(246, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // openFileDialogLB_GRA
            // 
            this.openFileDialogLB_GRA.FileName = "openFileDialogLB_GRA";
            // 
            // saveFileDialogLB_GRA
            // 
            this.saveFileDialogLB_GRA.FileName = "saveFileDialogLB_GRA";
            // 
            // textBoxSearch_GRA
            // 
            this.textBoxSearch_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_GRA.Location = new System.Drawing.Point(7, 20);
            this.textBoxSearch_GRA.Name = "textBoxSearch_GRA";
            this.textBoxSearch_GRA.Size = new System.Drawing.Size(423, 20);
            this.textBoxSearch_GRA.TabIndex = 0;
            this.textBoxSearch_GRA.TextChanged += new System.EventHandler(this.textBoxSearch_GRA_TextChanged);
            // 
            // buttonClear_GRA
            // 
            this.buttonClear_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear_GRA.Location = new System.Drawing.Point(436, 19);
            this.buttonClear_GRA.Name = "buttonClear_GRA";
            this.buttonClear_GRA.Size = new System.Drawing.Size(46, 24);
            this.buttonClear_GRA.TabIndex = 1;
            this.buttonClear_GRA.Text = "Очистьт";
            this.buttonClear_GRA.UseVisualStyleBackColor = true;
            this.buttonClear_GRA.Click += new System.EventHandler(this.buttonClear_GRA_Click);
            // 
            // buttonPS_GRA
            // 
            this.buttonPS_GRA.Location = new System.Drawing.Point(9, 19);
            this.buttonPS_GRA.Name = "buttonPS_GRA";
            this.buttonPS_GRA.Size = new System.Drawing.Size(34, 23);
            this.buttonPS_GRA.TabIndex = 0;
            this.buttonPS_GRA.Text = "+Str";
            this.buttonPS_GRA.UseVisualStyleBackColor = true;
            this.buttonPS_GRA.Click += new System.EventHandler(this.buttonPS_GRA_Click);
            // 
            // buttonDel_GRA
            // 
            this.buttonDel_GRA.Location = new System.Drawing.Point(49, 19);
            this.buttonDel_GRA.Name = "buttonDel_GRA";
            this.buttonDel_GRA.Size = new System.Drawing.Size(31, 23);
            this.buttonDel_GRA.TabIndex = 1;
            this.buttonDel_GRA.Text = "-Str";
            this.buttonDel_GRA.UseVisualStyleBackColor = true;
            this.buttonDel_GRA.Click += new System.EventHandler(this.buttonDel_GRA_Click);
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GRA.Location = new System.Drawing.Point(756, 4);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(74, 41);
            this.buttonHelp_GRA.TabIndex = 1;
            this.buttonHelp_GRA.Text = "Поддержка";
            this.buttonHelp_GRA.UseVisualStyleBackColor = true;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // buttonSubtract_GRA
            // 
            this.buttonSubtract_GRA.Location = new System.Drawing.Point(87, 18);
            this.buttonSubtract_GRA.Name = "buttonSubtract_GRA";
            this.buttonSubtract_GRA.Size = new System.Drawing.Size(61, 24);
            this.buttonSubtract_GRA.TabIndex = 2;
            this.buttonSubtract_GRA.Text = "Остаток";
            this.buttonSubtract_GRA.UseVisualStyleBackColor = true;
            this.buttonSubtract_GRA.Click += new System.EventHandler(this.buttonSubtract_GRA_Click);
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
            // groupBoxMid_GRA
            // 
            this.groupBoxMid_GRA.Controls.Add(this.dataGridViewLB_GRA);
            this.groupBoxMid_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMid_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMid_GRA.Name = "groupBoxMid_GRA";
            this.groupBoxMid_GRA.Size = new System.Drawing.Size(842, 393);
            this.groupBoxMid_GRA.TabIndex = 0;
            this.groupBoxMid_GRA.TabStop = false;
            this.groupBoxMid_GRA.Text = "Таблица";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.panelBot_GRA);
            this.Controls.Add(this.panelMid_GRA);
            this.Controls.Add(this.panelTop_GRA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.panelTop_GRA.ResumeLayout(false);
            this.groupBoxFile_GRA.ResumeLayout(false);
            this.panelMid_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLB_GRA)).EndInit();
            this.panelBot_GRA.ResumeLayout(false);
            this.groupBoxRed_GRA.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMid_GRA.ResumeLayout(false);
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
    }
}

