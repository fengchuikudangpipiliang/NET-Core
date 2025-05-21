namespace _1V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyDBContext context = new MyDBContext();
            Student s1 = new Student() {Name="张三" };
            Student s2 = new Student() { Name = "李四" };
            Student s3 = new Student() { Name = "王五" };

            Teachers t1= new Teachers() {Name="陈浩" };
            Teachers t2 = new Teachers() { Name="浩辰"};

            t1.Students.Add(s1);
            t2.Students.Add(s2);
            t2.Students.Add(s3);
            context.Teachers.Add(t1);
            context.Teachers.Add(t2);
            context.SaveChanges();

        }
    }
}
