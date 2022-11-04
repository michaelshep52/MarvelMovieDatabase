using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelDatabase.Reader
{
    public class FileRead
    {
        public void readdata()
        {
            FileStream fs = new FileStream("MCUMovies.csv.rtf", FileMode.Open, FileAccess.Read);
            //Position the File Pointer at the Beginning of the File
            StreamReader sr = new StreamReader(fs);
            //Read till the End of the File is Encountered
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine("{0}", str);
                str = sr.ReadLine();
            }
            //Close the Writer and File
            sr.Close();
            fs.Close();
        }
        public void FileReader()
        {
            FileRead fr = new FileRead();
            fr.readdata();
        }


    }
}