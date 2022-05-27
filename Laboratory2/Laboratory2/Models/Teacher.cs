using System;
using System.Collections.Generic;
using System.Xml;

namespace Laboratory2.Models
{
    public class Teacher : Human
    {
        public int Id { get; set; }
        public List<int> SubjectsId { get; set; } = new List<int>();

        public Teacher(string name = "", string surname = "", String patronymic = "", int id = -1) :
            base(name, surname, patronymic)
        {
            Id = id;
        }
    }
}