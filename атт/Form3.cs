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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static атт.Data;

namespace атт
{
    public partial class Form3 : Form
    {
        Form1 f1;
        DataBase data = new DataBase();
        public Form3(Form1 f1, bool GrouporClassroom_teather)
        {
            List<Classroom_teacher> classroom_teachers = new List<Classroom_teacher>();
            List<Students> students = new List<Students>();
            InitializeComponent();
            this.f1 = f1;
            if (GrouporClassroom_teather)
            {




                foreach (var u in data.at_List)
                {
                    foreach (Students students11 in u.students) students.Add(students11);

                }
                foreach (Students studets11 in students)
                {

                    classroom_teachers.Add(studets11.Classroom_teacher);

                }
                dataGridView1.DataSource = classroom_teachers;
            }
            else
            {
                List<Group> groups = new List<Group>();
                foreach (var u in data.at_List)
                {
                    groups.Add(u.Group1);
                }
                dataGridView1.DataSource = groups;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
