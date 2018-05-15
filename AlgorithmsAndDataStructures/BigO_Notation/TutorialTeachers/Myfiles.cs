using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    class Myfiles
    {

        public Myfiles()
        {
            CreateFile();
            StreamReading();
            //CreateFileInfo();
        }

        public void CreateFile()
        {
            string dummyLines = "This is first line." + Environment.NewLine +
                    "This is second line." + Environment.NewLine +
                    "This is third line." + Environment.NewLine;

            File.AppendAllLines(@"C:\DummyFile.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());
            File.AppendAllText(@"C:\DummyFile.txt", "This file is for testing");

            //OverWrites the files
            File.WriteAllText(@"C:\DummyFile.txt", "this is overiting file text");
        }

        public void CreateFileInfo()
        {
            bool isFileExist = File.Exists(@"C:\DummyFile.txt");

            if(!isFileExist)
            {
                FileInfo fi = new FileInfo(@"C:\DummyFile.txt");

                FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

                byte[] fileByte = new byte[fs.Length];

                int numberOfBytesToRead = fileByte.Length;

                int numberBytesRead = 0;

                while (numberOfBytesToRead > 0)
                {
                    int n = fs.Read(fileByte, numberOfBytesToRead, numberBytesRead);
                    if (n == 0)
                    {
                        break;
                    }

                    numberBytesRead += n;
                    numberOfBytesToRead -= n;
                }

                string fileString = Encoding.UTF8.GetString(fileByte);
            }
            
        }

        public void StreamReading()
        {
            FileInfo fi = new FileInfo(@"C:\DummyFile.txt");

            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            StreamReader sr = new StreamReader(fs);

            string FileContent = sr.ReadToEnd();

            sr.Close();
            fs.Close();
        }

        public void StreamWriting()
        {
            FileInfo fi = new FileInfo(@"C:\DummyFile.txt");

            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine("Testing");
            sr.Close();
            fs.Close();
        }
    }
}
