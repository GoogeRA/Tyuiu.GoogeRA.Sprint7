using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GoogeRA.Sprint7.Project0.V4.Lib;

namespace Tyuiu.GoogeRA.Sprint7.Project0.V4
{
    public partial class FormAboutGraf : Form
    {
        DataService ds = new DataService();
        private FormMain mainForm;
        public FormAboutGraf(FormMain mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }



        private void buttonOK_GRA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRes_GRA_Click(object sender, EventArgs e)
        {
            chartRes_GRA.Series[0].Points.Clear();
            int columnIndex = Convert.ToInt32(textBoxIndexCol_GRA.Text);
            DataGridViewRowCollection rows = mainForm?.GetRows();
            if (columnIndex > 3 && columnIndex < 7)
            {
                
                if (rows != null)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        if (row.Cells[0].Value != null && int.TryParse(row.Cells[columnIndex].Value.ToString(), out int number))
                        {
                            chartRes_GRA.Series[0].Points.AddXY(row.Cells[0].Value.ToString(), number);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверный номер! Доступны: 4, 5, 6.");
            }
        }

        private void chartFrom_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxIndexCol_GRA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
