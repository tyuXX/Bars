using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace BarsUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete(args[0]);
            using (WebClient client = new WebClient()) client.DownloadFile("https://raw.githubusercontent.com/tyuXX/Bars/master/Bars/bin/Debug/Bars.exe", "Bars.exe");
            Process.Start("Bars.exe");
            Thread.Sleep(10);
        }
    }
}
