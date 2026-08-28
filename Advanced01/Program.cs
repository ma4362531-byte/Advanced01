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

            #region Q 3
            //    //What are multiple type parameters? Write Pair<TKey, TValue>.

            //    Multiple Type Parameters: The capability of generics to accept more than one type placeholder(e.g., < TKey, TValue >), allowing classes or 
            //        methods to manage related elements of different types concurrently.

            //        public class Pair<TKey, TValue>
            //{
            //    public TKey Key { get; set; }
            //    public TValue Value { get; set; }

            //    public Pair(TKey key, TValue value)
            //    {
            //        Key = key;
            //        Value = value;
            //    }
            //} 
            #endregion

            #region Q 4
            //    // What is a generic method? Write Swap<T> method.

            //    Generic Method: A method declared with type parameters independently of its containing
            //        class, allowing it to execute operations on generic parameters.

            //    public static class Helper
            //{
            //    public static void Swap<T>(ref T a, ref T b)
            //    {
            //        T temp = a;
            //        a = b;
            //        b = temp;
            //    }
            //} 
            #endregion

            #region Q 5

            // Write a generic method FindMax < T > that finds maximum value.

            //    Note: Requires the where T : IComparable<T>
            //        constraint to enable comparison operations using .CompareTo().

            //    public static class Utility
            //{
            //    public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //    {
            //        return a.CompareTo(b) > 0 ? a : b;
            //    }
            //} 
            #endregion

            #region Q 6
            //    // What is a generic interface? Write IRepository<T>.

            //    Generic Interface: An interface defined with generic type parameters that enforces a standardized contract
            //    (such as Data Access operations) for any entity type.

            //    public interface IRepository<T>
            //{
            //    void Add(T entity);
            //    T GetById(int id);
            //    IEnumerable<T> GetAll();
            //} 
            #endregion







        }
    }
}
