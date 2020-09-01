using System;
using System.Threading;

namespace dotnet_image_docker
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Hello World! -  {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
