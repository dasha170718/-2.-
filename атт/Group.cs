using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace атт
{
    internal class Group
    {

        private string _name;
        private int _numberOfStudents;
        public Group(string name)
        {
            _name = name;
            _numberOfStudents = 27;
        }
        public string Name
        {
            get => _name;
        }
        public int NumberOfStudents
        {
            get => _numberOfStudents;
        }
    }
}
