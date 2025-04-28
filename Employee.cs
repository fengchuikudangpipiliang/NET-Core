namespace NET_Core
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public override string ToString()
        {
            return string.Format($"firstName:{firstName},lastName:{lastName}");
        }
    }
}
