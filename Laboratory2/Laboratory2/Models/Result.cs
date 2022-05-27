namespace Laboratory2.Models
{
    public class Result
    {
        public Human Human { get; }
        public int Gpa { get; }

        
        public Result(Human human, int gpa)
        {
            Human = human;
            Gpa = gpa;
        }
        
    }
}