using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class BuildingObject
    {
        private Object obj;

        public Object Obj
        {
            get
            {
                return obj;
            }
            set
            {
                obj = value;
            }
        }

        public T method<T>(T type) {

            return type;
        }
    }
}
