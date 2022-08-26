// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System.Diagnostics;

namespace ConsoleApp1
{
    public class Copads
    {
        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var di = Directory.GetFiles("./");
            foreach (var d in di)
            {
                var f = new FileInfo(d);
                f.Refresh();

                var fileYear = long.Parse(f.LastWriteTime.Year.ToString());
                var currYear = long.Parse(DateTime.Now.Year.ToString());

                var fileTime = f.LastWriteTime.ToString("MMM dd HH:mm");
                
                if (fileYear != currYear)
                {
                   fileTime = f.LastWriteTime.ToString("MMM dd yyyy HH:mm");
                }
                
                Console.WriteLine("{0, 10}, {1}, {2}", f.Length, fileTime, f);
            }
            
            stopwatch.Stop();
            Console.WriteLine("\n" + stopwatch.Elapsed);
            Console.ReadKey();
        }
    }    
}
