using System.Security.Cryptography;
using static атт.Data;

namespace атт
{
    public partial class Form1 : Form
    {
        DataBase data = new DataBase();
        int indexDelRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add("Column1", "Наименование группы");
            dataGridView1.Columns.Add("Column2", "ФИО кл.рук");
            dataGridView1.Columns.Add("Column3", "Количество аттестованных студентов");

            fillData();
            comboBox1.Items.Add("Лукьянова Е.П");
            comboBox1.Items.Add("Гартман Е.П");
        }
        private void fillData()
        {

            foreach (var i in data.at_List)
            {
                dataGridView1.Rows.Add(i.Name, i.Group, i.CountStudents);
            }

        } 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || data.at_List.Count <= index) return;
            List<Students> students = data.at_List[index].students.ToList();

            
            Form2 students1 = new Form2(students, this);
            students1.Show();
            this.Hide();
        } 
        private void button1_Click_1(object sender, EventArgs e)
        {
            var newData = data.at_List.OrderByDescending(u => u.CountStudents).ToList();
            dataGridView1.Rows.Clear();
            foreach (var i in newData)
            {
                dataGridView1.Rows.Add(i.Name, i.Group, i.CountStudents);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.Rows.Clear();
            foreach (var i in data.at_List)
            {
                dataGridView1.Rows.Add(i.Name, i.Group, i.CountStudents);
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    var newData = data.at_List.Where(u => u.Group.Contains("Лукьянова Е.П")).ToList();
                    dataGridView1.Rows.Clear();
                    foreach (var i in newData)
                    {

                        dataGridView1.Rows.Add(i.Name, i.Group, i.CountStudents);
                    }
                    break;
                case 1:
                    var newData1 = data.at_List.Where(u => u.Group.Contains("Гартман Е.П")).ToList();
                    dataGridView1.Rows.Clear();
                    foreach (var i in newData1)
                    {

                        dataGridView1.Rows.Add(i.Name, i.Group, i.CountStudents);
                    }
                    break;
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indexRows = dataGridView1.CurrentCell.RowIndex;
            int indexColumn = dataGridView1.CurrentCell.ColumnIndex;
            if (indexRows == -1 || data.at_List.Count <= indexRows) return;

            switch (indexColumn)
            {
                case 0:
                    data.at_List[indexRows].Name = dataGridView1.Rows[indexRows].Cells[indexColumn].Value.ToString();
                    break;
            }
        } 
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            indexDelRow = e.Row.Index;
            if (indexDelRow == -1) return;
            data.at_List.RemoveAt(indexDelRow);
        }
        
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("", "");
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 data = new Form3(this, true);
            data.Show();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 data = new Form3(this, false);
            data.Show();
        }

       
        private void button5_Click_1(object sender, EventArgs e)
        {
            List<Students> students = new List<Students>();
            string name = textBox1.Text;
            string group = textBox2.Text;
            string countStudents = textBox3.Text;
            data.at_List.Add(new At_List(students, new Group(group), name, countStudents));
            button2_Click_1(sender, e);
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}