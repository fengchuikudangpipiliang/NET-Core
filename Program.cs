

namespace NET_Core
{
    internal class Program
    {
        static async Task  Main()
        {
            MyDBContext dbContext = new MyDBContext();
            dbContext.Persons.Add(new Person() { Name = "chenhao", Age = 1, BirthPlace = "shangjao", Height = 180, Weight = 120 });
            await dbContext.SaveChangesAsync();
        }
    }
  
}
