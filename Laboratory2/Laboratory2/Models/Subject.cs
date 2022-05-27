namespace Laboratory2.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject(string name = "", int id = -1)
        {
            Id = id;
            Name = name;
        }
    }
}