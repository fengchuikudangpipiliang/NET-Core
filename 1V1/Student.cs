

namespace _1V1
{
    public class Student
    {
        public long Id { get; set; }    
        public string Name { get; set; }
        public List<Teachers> Teachers { get; set; } = new List<Teachers>();
    }
}
