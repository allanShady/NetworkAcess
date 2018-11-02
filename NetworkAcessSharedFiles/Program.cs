using NetworkAcessSharedFiles.Helpers;
using System;
using System.Linq;
using System.Text;

namespace NetworkAcessSharedFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var networkPath = @"\\Desktop-m32m6di\priserver";
            var credentials = new System.Net.NetworkCredential("levi.camoes", "levi2018");

            using (new NetworkConnection(networkPath, credentials))
            {
                StringBuilder fileDir = new StringBuilder();

                fileDir.Append(@"\\Desktop-m32m6di\priserver");
                fileDir.Append(@"\");
                fileDir.Append("Peso.txt");
                
                var fileContet = FileProcessor.LoadFile(fileDir.ToString());
                Console.WriteLine($"From: {fileDir}\n{fileContet.FirstOrDefault()}");
                //var fileList = Directory.GetFiles(networkPath);
            }
            Console.ReadLine();
        }
    }
}
