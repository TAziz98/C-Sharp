using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : Person
    {

        public enum Degree { DoctorOfScience, MasterDegree, Proffesor };
        private Degree deg;
        StreamWriter streamW; StreamReader streamR;
        public Teacher(string name, string surname, int age, string nation, Degree degree) : base(name, surname, age, nation)
        {
            this.TeacherDegree = degree;

        }
        public Degree TeacherDegree
        {
            get
            {
                return deg;
            }
            set
            {
                deg = value;
            }
        }

        public Dictionary<Student, int> gradeTest(Student student, int numbExercDone)
        {
            var dictonary = new Dictionary<Student, int>();
            int grade = 0;
            if (this != null)
            {
                switch (numbExercDone)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        grade = 2;
                        break;
                    case 5:
                    case 6:
                        grade = 3;
                        break;
                    case 7:
                    case 8:
                        grade = 4;
                        break;
                    case 9:
                    case 10:
                        grade = 5;
                        break;
                }

            }
            dictonary.Add(student, grade);
            return dictonary;

        }

        public String toString()
        {
            return this.Name + " "+this.LastName+" " + TeacherDegree;
        }


        public override bool writeL(string filename) {
            bool result=false;
            streamW = new StreamWriter(filename);
            try {
                string[] info = {this.Name.ToString(),this.LastName.ToString(),this.Age.ToString(),this.Nationality.ToString(),this.TeacherDegree.ToString()};
                using (streamW)
                {
                    foreach (string each in info)
                    {
                        streamW.WriteLine(each);
                    }
                }
                result= true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                result=false;
            }
            finally
            {
                streamW.Close();
                streamW = null;
               
            }
            return  result;
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

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~Teacher() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
     
        #endregion
    }
}
