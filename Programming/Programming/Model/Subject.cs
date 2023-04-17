﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Subject
    {
        string _name;
        string _teacher;
        int _mark;

        private string Name
        {
            get => _name;
            set
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentException("Укажите название предмета");
            }

        }

        private string Teacher
        {
            get => _teacher;
            set
            {
                if (value != null)
                    _teacher = value;
                else
                    throw new ArgumentException("Укажите имя преподователя");
            }

        }

        private int Mark
        {
            get => _mark;
            set
            {
                string method = "Mark";

                bool check = Validator.AssertValueInRange(method, value, 1, 5);

                if (check == true)
                    _mark = value;
            }

        }

        public Subject()
        {

        }

        public Subject(string name, string teacher, int mark)
        {
            Name = name;
            Teacher = teacher;
            Mark = mark;
        }
    }
}
