using System;

namespace Laboratory2.Models
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        protected Human(string name = "", string surname = "", string patronymic = "")
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }
        
    }
}