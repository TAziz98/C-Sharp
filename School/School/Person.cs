using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    abstract class Person :IDisposable
    {
      private  string nation;
        private string name;
        private string surname;
       private int p_age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
     
        public string Nationality
        {
            get
            {
                return nation;
            }
            set
            {
                nation = value;
            }
        }
        public string LastName
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return p_age;
            }
            set
            {
                p_age = value;
            }
        }
        public Person(string name,string surname,int age,string nationn)
        {
            this.Name = name;
            this.LastName = surname;
            this.Age = age;
            this.Nationality = nationn;
        }
        abstract public  bool writeL(string filename);
        abstract public  bool readL(string filename);
        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~Person() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
             GC.SuppressFinalize(this);
        }
        #endregion

    }
}
