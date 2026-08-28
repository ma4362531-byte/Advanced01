using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1

            //What is a generic class? Why use generics?

            //    Generic Class: A class that allows code to operate on specified data types defined as parameters when instantiated.It acts as a blueprint for
            //        type-safe data handling without fixing the data type at compile-time.

            //        Reusability: Write code once and use it with any data type.

            //Type Safety: Type checks occur at compile-time rather than runtime, eliminating InvalidCastException.

            //Performance: Eliminates the overhead of boxing and unboxing value types (e.g., converting int to object).

            #endregion

            #region Q 2

            //        // Write a generic class Container<T> with Add and Get methods.

            //        public class Container<T>
            //    { 
            //        private T _value;

            //    public void Add(T item)
            //    {
            //        _value = item;
            //    }

            //    public T Get()
            //    {
            //        return _value;
            //    }

            //} 
            #endregion




        }
    }
}
