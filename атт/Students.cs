using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace атт
{
    internal class Students:People
    {
        private Classroom_teacher _classroom_teacher;
        public Students(string name, int age, Sex sex, Classroom_teacher classroom_teacher) : base(name, age, sex)
        {
            _classroom_teacher = classroom_teacher;
        }
        public Classroom_teacher Classroom_teacher
        {
            get => _classroom_teacher;
        }
        public string GetParent()
        {
            return _classroom_teacher.Name;
        }
    }
}
