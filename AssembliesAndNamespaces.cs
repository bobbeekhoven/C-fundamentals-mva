using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class AssembliesAndNamespaces
    {
        static void Main(string[] args)
        {
           
            //string text = "We want to write this to our file. ";
             //System.IO.File.WriteAllText(@"C:\Lesson17\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");


            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Lesson17\WriteText.txt", reply);
            Console.ReadLine();

        }
    }
}
