using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace атт
{
    public enum Sex
    {
        M,
        W
    }
    internal class People
    {
        private string _name;
        private int _age;
        private Sex _sex;
        public People(string name, int age, Sex sex)
        {
            _name = name;
            _age = age;
            _sex = sex;
        }
        public string Name
        {
            get => _name;
        }
        public int Age
        {
            get => _age;
        }
        public Sex Sex
        {
            get => _sex;
        }
    }
}
