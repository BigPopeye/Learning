using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Mod3_SelfLab
{
    public class CourseRecord : IDisposable
    {
        public string RecordName { get; set; }

        private string path;
        private FileStream recordFile = null;
        private StreamReader recordStream = null;
        private bool isDispose = false;
        public CourseRecord(string courseName)
        {
            this.RecordName = courseName;
            this.path = courseName + ".txt";
            recordFile = File.Create(this.path);
            recordFile.Close();
        }
        public void Print()
        {
            try
            {
                recordStream = new StreamReader(this.path);
                String records = recordStream.ReadToEnd();
                Console.WriteLine(records);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This file : {0} cannot be found.", this.path);
            }
        }

        public bool Add(string record)
        {
            try
            {
                if (record != null && path != null)
                {
                    File.AppendAllText(this.path, record);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This file : {0} cannot be found.", path);
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.isDispose)
            {
                if (disposing)
                {
                    if (this.RecordName != null)
                    {
                        this.RecordName = null;
                    }
                    if (this.path != null)
                    {
                        this.path = null;
                    }
                }
                if (recordStream != null)
                {
                    recordStream.Close();
                    
                }
                if (recordFile != null)
                {
                    recordFile.Close();
                }
                isDispose = true;
            }
        }

        ~CourseRecord()
        {
            Dispose(false);
        }
    }
}
