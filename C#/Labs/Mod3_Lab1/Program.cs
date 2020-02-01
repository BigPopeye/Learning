using System;
using System.Globalization;
using System.IO;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReaderObject = null; // StreamReader base TextReader has 

            try
            {
                streamReaderObject = new StreamReader("file1.txt");
                String contents = streamReaderObject.ReadToEnd();

                Console.WriteLine(contents);
                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This file cannot be found.");
            }
            finally
            {
                if(streamReaderObject != null)
                {
                    streamReaderObject.Close();
                    streamReaderObject.Dispose();
                }
            }
        }
        
    }
}
