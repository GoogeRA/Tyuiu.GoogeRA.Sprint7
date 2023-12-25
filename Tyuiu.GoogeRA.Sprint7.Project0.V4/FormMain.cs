using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GoogeRA.Sprint7.Project0.V4.Lib;

namespace Tyuiu.GoogeRA.Sprint7.Project0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogLB_GRA.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogLB_GRA.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }


        private void buttonOpenFile_GRA_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogLB_GRA.ShowDialog() != DialogResult.Cancel)
                {
                    string filepath = openFileDialogLB_GRA.FileName;
                    var rows = dataGridViewLB_GRA.Rows;
                    string[] content = File.ReadAllLines(filepath, Encoding.Default);
                    dataGridViewLB_GRA.RowCount = content.Length;
                    for (int i = 0; i < content.Length; i++)
                    {
                        for (int j = 0; j < content[0].Split(';').Length; j++)
                        {
                            rows[i].Cells[j].Value = content[i]?.Split(';')[j];
                        }
                    }
                }
                buttonSaveFile_GRA.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_GRA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogLB_GRA.FileName = "OutPutFileProject.csv";
                saveFileDialogLB_GRA.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogLB_GRA.ShowDialog();

                string path = saveFileDialogLB_GRA.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewLB_GRA.RowCount;
                int columns = dataGridViewLB_GRA.ColumnCount;
                string header = "";
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        header += dataGridViewLB_GRA.Columns[j].HeaderText + ";";
                    }
                    else
                    {
                        header += dataGridViewLB_GRA.Columns[j].HeaderText;
                    }
                }
                File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


                for (int i = 0; i < rows; i++)
                {
                    string str = "";
                    for (int j = 0; j < columns; j++)
                    {

                        if (j != columns - 1)
                        {
                            str += dataGridViewLB_GRA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewLB_GRA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLB_GRA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                string indexStr = (index + 1).ToString();
                object header = this.dataGridViewLB_GRA.Rows[index].HeaderCell.Value;
                if (header == null || !header.Equals(indexStr))
                    this.dataGridViewLB_GRA.Rows[index].HeaderCell.Value = indexStr;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Промах!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_GRA_TextChanged(object sender, EventArgs e)
        { 
            // Поиск по всем столбцам
            for (int i = 0; i < dataGridViewLB_GRA.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < dataGridViewLB_GRA.Columns.Count; j++)
                {
                    if (dataGridViewLB_GRA[j, i].Value.ToString() == textBoxSearch_GRA.Text)
                    {
                        isVisible = true;
                    }
                }
                dataGridViewLB_GRA.Rows[i].Visible = isVisible;
            }
        }
        
        private void buttonClear_GRA_Click(object sender, EventArgs e)
        {
            textBoxSearch_GRA.Text = "";
            textBoxSearch_GRA.Clear();
            for (int i = 0; i < dataGridViewLB_GRA.Rows.Count - 1; i++)
            {
                dataGridViewLB_GRA.Rows[i].Visible = true;
            }
        }

        private void buttonPS_GRA_Click(object sender, EventArgs e)
        {
            dataGridViewLB_GRA.Rows.Add();
        }

        private void buttonDel_GRA_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRowIndex = dataGridViewLB_GRA.SelectedCells[0].RowIndex;
                dataGridViewLB_GRA.Rows.RemoveAt(selectedRowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GRA_Click(object sender, EventArgs e)
        {
            FormAbout formAboutHelp = new FormAbout();
            formAboutHelp.Show();
        }

        private void SubtractSelectedRows()
        {
            // Проверить, есть ли выбранные строки
            if (dataGridViewLB_GRA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну строку для вычитания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int columnToSubtractIndex = 5; 
            int columnToSubtractFromIndex = 4; 
            int colmnToSubstractRes = 6;
            
            foreach (DataGridViewRow row in dataGridViewLB_GRA.SelectedRows)
            {
                // Проверить есть ли значения в выбранных столбцах
                if (row.Cells[columnToSubtractIndex].Value == null || row.Cells[columnToSubtractFromIndex].Value == null)
                {
                    continue;
                }
                // Получить значения из выбранных столбцов
                int valueToSubtract = Convert.ToInt32(row.Cells[columnToSubtractIndex].Value);
                int valueToSubtractFrom = Convert.ToInt32(row.Cells[columnToSubtractFromIndex].Value);

                // Вычислить разность и обновить значение в новом столбце 
                row.Cells[colmnToSubstractRes].Value = valueToSubtractFrom - valueToSubtract;
            }
        }

        private void buttonSubtract_GRA_Click(object sender, EventArgs e)
        {
            SubtractSelectedRows();
        }

        private void buttonAllB_GRA_Click(object sender, EventArgs e)
        {
            int columnIndex;
            try
            {
                if (int.TryParse(textBoxNumColumn_GRA.Text, out columnIndex))
                {
                    int sum = 0;
                    foreach (DataGridViewRow row in dataGridViewLB_GRA.Rows)
                    {
                        if (row.Cells[columnIndex].Value != null && int.TryParse(row.Cells[columnIndex].Value.ToString(), out int cellValue))
                        {
                            sum += cellValue;
                        }
                    }
                    textBoxSumCol_GRA.Text = sum.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Неверный индекс столбца! Нумерация от 0!");
            }

        }

        private void buttonChart_GRA_Click(object sender, EventArgs e)
        {

            FormAboutGraf formAboutGraf = new FormAboutGraf(this);
            formAboutGraf.Show();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

   
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        public DataGridViewRowCollection GetRows()
        {
            DataGridViewRowCollection rows = dataGridViewLB_GRA.Rows;
            return rows;
        }

        private void buttonINFO_GRA_Click(object sender, EventArgs e)
        {
            FormAboutInfo formAboutinfo = new FormAboutInfo();
            formAboutinfo.Show();
        }
    }
    
    
}

