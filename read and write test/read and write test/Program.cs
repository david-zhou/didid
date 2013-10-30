using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace read_and_write_test
{
    class hola
    {
        public hola()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("sample.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("prueba.txt");

                //Write a line of text
                sw.WriteLine("dsafvbawvbrl");

                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");

                //Close the file
                sw.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            Console.ReadKey();
        }
    }
}
