using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace атт
{
    partial class Form2 : Form
    {
        Form1 f1;
        public Form2(List<Students> students,Form1 f)
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            f1 = f;
            dataGridView1.Columns.Add("Column1", "ФИО");
            dataGridView1.Columns.Add("Column2", "Классный руководитель");
            dataGridView1.Columns.Add("Column3", "Возраст");
            try
            {
                foreach (var i in students)
                {
                    dataGridView1.Rows.Add(i.Name, i.Classroom_teacher, i.Age);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

       
    
