namespace _1V1
{
    public class Delivery
    {
        public long Id { get; set; }    
        public Order Order { get; set; }
        public long OrderId {  get; set; }
    }
}
