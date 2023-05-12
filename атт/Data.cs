using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace атт
{
    internal class Data
    {
        public class DataBase
        {
            private Random _rand = new Random();
           

            public List<At_List> at_List { get; private set; }
            public DataBase()
            {
                List<Students> students = new List<Students>()//Студенты первой группы
                {
                    new Students("Аршин Д.В",19,Sex.M,new Classroom_teacher("Гартман Е.П",35,Sex.W)),
                    new Students ("Алемазова А.А",19,Sex.W,new Classroom_teacher("Гартман Е.П",35,Sex.W)),
                    new Students("Вашкевич К.Н",19,Sex.M,new Classroom_teacher("Гартман Е.П",35,Sex.W)),
                    new Students("Диесперов К.А",18,Sex.M,new Classroom_teacher("Гартман Е.П",35,Sex.W))
                };
                List<Students> students1 = new List<Students>()//Студенты второй группы
                {
                    new Students("Кто-то1",18,Sex.M,new Classroom_teacher("Лукьянова Е.П",35,Sex.W)),
                    new Students("Кто-то2",18,Sex.M,new Classroom_teacher("Лукьянова Е.П",35,Sex.W)),
                    new Students("Кто-то3",18,Sex.M,new Classroom_teacher("Лукьянова Е.П",35,Sex.W)),
                    new Students("Кто-то4",18,Sex.M,new Classroom_teacher("Лукьянова Е.П",35,Sex.W)),
                new Students("кто-то5",18,Sex.M,new Classroom_teacher("Лукьянова Е.П",35,Sex.W))
            };


                at_List = new List<At_List>()
            {
                new At_List(students,new Group("ИС(ПРО)-32"),"Гартман Е.П"),
                new At_List(students1,new Group("ИС(ПРО)-31"),"Лукьянова Е.П")

            };
            }




        }
    }
}
