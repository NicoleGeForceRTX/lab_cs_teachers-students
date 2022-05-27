namespace Laboratory2.Models
{
    public class SubjectGrade
    {

        private int _grade;
        
        public int SubjectId { get; }

        public int Grade
        {
            get => _grade;
            set
            {
                if (value < 0 || value > 100) return;
                _grade = value;
            }
        }

        public SubjectGrade(int subjectId, int grade)
        {
            SubjectId = subjectId;
            Grade = grade;
        }
    }
}