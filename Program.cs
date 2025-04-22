using System;
namespace NET_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\code\c#\test.txt";
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            for (int i = 0; i < 20; i++)
            {
                fileStream.WriteByte((byte)i);
            }
            fileStream.Position = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(fileStream.ReadByte() + " ");
            }

        }
    }
}
