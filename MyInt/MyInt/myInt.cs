using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInt
{
    class myInt
    {
        private object value;

        public myInt()
        {
            value = null;
        }
        public myInt(object p)
        {
            this.value = p;
        }
        public myInt(int value)
        {
            this.value = value;
        }
        public string Value
        {
            get
            {
                try
                {
                    return value.ToString();
                }
                catch (NullReferenceException)
                {
                    return "null";
                }
            }
        }

        public static implicit operator myInt(int v)
        {
            try
            {
                return new myInt(v);
            }
            catch (NullReferenceException)
            {

                return new myInt();
            }
        }
        public static myInt operator +(myInt obj1, myInt obj2)
        {
            try
            {
                return new myInt(int.Parse(obj1.value.ToString()) + int.Parse(obj2.value.ToString()));
            }
            catch (NullReferenceException)
            {

                return new myInt();
            }

        }
        public static myInt operator -(myInt obj1, myInt obj2)
        {
            try
            {
                return new myInt(int.Parse(obj1.value.ToString()) - int.Parse(obj2.value.ToString()));
            }
            catch (NullReferenceException)
            {

                return new myInt();
            }
        }
        public static myInt operator *(myInt obj1, myInt obj2)
        {
            try
            {
                return new myInt(int.Parse(obj1.value.ToString()) * int.Parse(obj2.value.ToString()));
            }
            catch (NullReferenceException)
            {

                return new myInt();
            }
        }
        public static myInt operator /(myInt obj1, myInt obj2)
        {
            try
            {
                return new myInt(int.Parse(obj1.value.ToString()) / int.Parse(obj2.value.ToString()));
            }
            catch (NullReferenceException)
            {

                return new myInt();
            }
        }
        public static myInt operator %(myInt obj1, myInt obj2)
        {
            try
            {
                return new myInt(int.Parse(obj1.value.ToString()) % int.Parse(obj2.value.ToString()));
            }
            catch (NullReferenceException)
            {

                return new myInt();
            }
        }
        public static bool operator >(myInt obj1, myInt obj2)
        {
            return int.Parse(obj1.value.ToString()) > int.Parse(obj2.value.ToString());
        }
        public static bool operator <(myInt obj1, myInt obj2)
        {
            return int.Parse(obj1.value.ToString()) < int.Parse(obj2.value.ToString());
        }
        public static bool operator ==(myInt obj1, myInt obj2)
        {
            return int.Parse(obj1.value.ToString()) == int.Parse(obj2.value.ToString());
        }
        public static bool operator !=(myInt obj1, myInt obj2)
        {
            return int.Parse(obj1.value.ToString()) != int.Parse(obj2.value.ToString());
        }
    }
}
