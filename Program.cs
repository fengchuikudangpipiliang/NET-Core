namespace NET_Core
{
    internal class Program
    {
        static async Task  Main()
        {
            using(MyDBContext context = new MyDBContext())
            {
                context.Books.Add(new Book
                {
                    Title = "猜猜我有多爱你",
                    Pubtime = new DateTime(2015, 6, 1),
                    Price = 29.80
                });
                context.Books.Add(new Book
                {
                    Title = "不一样的卡梅拉",
                    Pubtime = new DateTime(2012, 3, 15),
                    Price = 35.00
                });
                context.Books.Add(new Book
                {
                    Title = "大卫，不可以",
                    Pubtime = new DateTime(2013, 5, 20),
                    Price = 25.00
                });
                context.Books.Add(new Book
                {
                    Title = "蚯蚓的日记",
                    Pubtime = new DateTime(2014, 8, 10),
                    Price = 22.50
                });
                context.Books.Add(new Book
                {
                    Title = "小猪唏哩呼噜",
                    Pubtime = new DateTime(2016, 1, 5),
                    Price = 32.80
                });
                context.Books.Add(new Book
                {
                    Title = "窗边的小豆豆",
                    Pubtime = new DateTime(2011, 11, 10),
                    Price = 39.00
                });
                context.Books.Add(new Book
                {
                    Title = "皮皮鲁和鲁西西",
                    Pubtime = new DateTime(2010, 9, 1),
                    Price = 28.00
                });
                context.Books.Add(new Book
                {
                    Title = "神奇校车",
                    Pubtime = new DateTime(2017, 2, 12),
                    Price = 33.60
                });
                context.Books.Add(new Book
                {
                    Title = "我爸爸",
                    Pubtime = new DateTime(2013, 4, 18),
                    Price = 26.00
                });
                context.Books.Add(new Book
                {
                    Title = "团圆",
                    Pubtime = new DateTime(2015, 7, 7),
                    Price = 30.00
                });
                await context.SaveChangesAsync(); 
                Console.WriteLine("10本儿童读物已添加至数据库。");
            }
        }
    }
  
}
