using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDll
{
        public class Teacher //Класс Учитель в котором будет находиться ФИО-преподователя и преподаваемая дисциплина
        {
            public string Name { get; set; }
            public string Course { get; set; }
            public Teacher(string FIO, string cr)
            {
                Name = FIO;
                Course = cr;
            }
            public void Show()
            {
                Console.WriteLine($"ФИО учителя:{Name},Преподаваемая дисциплина:{Course}");
            }

        }
}

