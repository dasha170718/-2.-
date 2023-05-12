using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace атт
{
    internal class At_List
    {
        private List<Students> _students;
        private Group _group;
        private string _name;
        private string countStudents;

        public At_List(List<Students> students, Group group, string name)
        {
            _students = students;
            _group = group;
            _name = name;
        }

        public At_List(List<Students> students, Group group, string name, string countStudents) : this(students, group, name)
        {
            this.countStudents = countStudents;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Group
        {
            get => _group.Name;
        }
        public Group Group1 { get => _group; }

        public int CountStudents
        {
            get => _students.Count;
        }
        public List<Students> students
        {
            get => _students;
        }
    }
}

