

namespace _1V1
{
    public class Teachers
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
