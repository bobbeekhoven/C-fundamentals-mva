using System;
using System.IO;


namespace HandlingExceptions
{
    class HandlingExceptions
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Example.txt");
                Console.WriteLine(content); 
            }
            catch (FileNotFoundException  ex)
            {
                Console.WriteLine("There was a problem! (Kenny changed his name!)");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a Problem! (Kenny does not exist!)");
                Console.WriteLine(@"Make sure the directory C:\Lesson 22 exists");
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was a problem! (Kenny's missing!)");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code top finalize
                // Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now ... (Erasing Kenny!)");
            }
            Console.ReadLine();
        }
    }
}
