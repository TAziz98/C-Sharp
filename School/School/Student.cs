using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : Person
    {
        public enum EducationLevel { Bachelor, Master, Doctor };
        private string studentNumb;
        private EducationLevel studentDegree;
        StreamWriter streamW; StreamReader streamR;
        public EducationLevel stDegree
        {
            get
            {
                return studentDegree;
            }
            set
            {
                studentDegree = value;
            }
        }
      

    
        public string StudentNumb
        {
            get
            {
                return studentNumb;
            }
            set
            {
                studentNumb = value;
            }
        }

        public Student(string name,string surname,int age, string nation, string studentNumb, EducationLevel studentsDegree) : base(name,surname,age,nation)
        {
            this.StudentNumb = studentNumb;
            this.stDegree = studentsDegree;
         
        }
        public bool takeTest(string test)
        {
            bool IsTakeTest = true;
            if (this != null)
            {

                if (test != null)
                    return IsTakeTest;
                else
                    test = "New Test";
            }
                return IsTakeTest;
            }
        public override bool writeL(string filename)
        {
            bool result = false;
            streamW = new StreamWriter(filename);
            try
            {
                string[] info = { this.Name.ToString(), this.LastName.ToString(), this.Age.ToString(), this.Nationality.ToString(),this.StudentNumb.ToString(), this.studentDegree.ToString() };
                using (streamW)
                {
                    foreach (string each in info)
                    {
                        streamW.WriteLine(each);
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                result = false;
            }
            finally
            {
                streamW.Close();
                streamW = null;

            }
            return result;
        }


        public override bool readL(string filename)
        {
            bool result = false;
            streamR = new StreamReader(filename);
            try
            {
                using (streamR)
                {
                    string content = streamR.ReadToEnd();
                    Console.WriteLine(content);
                }
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                result = false;
            }
            finally
            {
                streamR.Close();
                streamR = null;

            }
            return result;
        }
        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                    if (streamW != null)
                    {
                        streamW.Close();
                    }
                    if (streamR != null)
                    {
                        streamR.Close();
                    }
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
                base.Dispose(disposing);
            }
        }

       
        #endregion
    }


    }



