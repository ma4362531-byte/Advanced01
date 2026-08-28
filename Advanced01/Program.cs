using Microsoft.VisualBasic;
using System.Data;
using System.Data.Common;
using System.Numerics;
using System.Reflection.Metadata;
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

            #region Q 7
            // What is the 'struct' constraint? Write an example.

            //    where T : struct Constraint : Restricts the type parameter T to non-nullable value types
            //    (e.g., int, double, bool, or custom structs).

            //    public class ValueContainer<T> where T : struct
            //{
            //    public T Value { get; set; }
            //} 
            #endregion

            #region Q 8
            // What is the 'class' constraint? Write an example.

            //    where T : class Constraint : Restricts the type parameter T to reference types
            //    (e.g., string, delegates, array types, or custom classes).

            //    public class ReferenceContainer<T> where T : class
            //{
            //    public T Value { get; set; }
            //} 
            #endregion

            #region Q9
            // What is the 'new()' constraint? Write an example.

            //        where T : new () Constraint: Requires the type argument to have a public parameterless constructor, 
            //        enabling instantiation inside the generic class using new T().

            //    public class Factory<T> where T : new()
            //{
            //    public T CreateInstance()
            //    {
            //        return new T();
            //    }
            //} 
            #endregion

            #region Q10
            //    // What is the interface constraint? Write an example.

            //    Interface Constraint: Restricts the type parameter T to types that implement a specific interface,
            //    allowing access to that interface's members within the class.

            //    public class DataProcessor<T> where T : IDisposable
            //{
            //    public void ProcessAndClean(T item)
            //    {
            //        item.Dispose();
            //    }
            //} 
            #endregion

            #region Q11
            //    What is the base class constraint? Write an example.

            //    Base Class Constraint: Specifies that the type argument must inherit from a 
            //    specific base class (or be that base class itself).

            //    public class Entity
            //{
            //    public int Id { get; set; }
            //}

            //public class EntityRepository<T> where T : Entity
            //{
            //    public void LogId(T entity)
            //    {
            //        Console.WriteLine(entity.Id);
            //    }
            //} 
            #endregion

            #region Q12

            //            // How do you apply multiple constraints? Write an example.

            //            Multiple Constraints: Applied using comma-separated constraints for a single parameter.

            //Order Rule: The class or struct constraint must come first, followed by interface
            //            constraints, and new () must be last.

            //            public class AdvancedHandler<T> where T : Entity, IComparable<T>, new()
            //        {
            //            public T Process(T item)
            //            {
            //                return new T();
            //            }
            //        } 
            #endregion

            #region Q13
            //            // What does the 'default' keyword do in generics ?

            //            default Keyword: Evaluates to the default value of a type parameter at runtime:

            //            null for reference types (class).

            //0, 0.0, or bitwise zero representation for value types(struct).

            //            T value = default(T); 

            #endregion

            #region Q14
            //    // Write a SafeList < T > that returns default when the index is invalid.

            //    public class SafeList<T>
            //{
            //    private readonly List<T> _items = new List<T>();

            //    public void Add(T item) => _items.Add(item);

            //    public T Get(int index)
            //    {
            //        if (index < 0 || index >= _items.Count)
            //        {
            //            return default;
            //        }
            //        return _items[index];
            //    }
            //}

            #endregion












        }
    }
}
