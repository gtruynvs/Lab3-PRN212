using System.Collections;
using System.ComponentModel;

namespace Lab3_PRN212
{
    internal class Program
    {
        public class MyCollection<T> : IEnumerable where T : class, new()
        {
            private List<T> list = new List<T>();
            public void AddItem(params T[] item) => list.AddRange(item);
            IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
        }

        public static T Input<T>()
        {
            var input = Console.ReadLine();
            if (input == null)
                return default;
            return (T)Convert.ChangeType(input, typeof(T));
        }


        public static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("===========MENU===========");
                    Console.WriteLine("1. Add, Subtract, Multiply, Divide with Generics");
                    Console.WriteLine("2. Illustrate Arraylist");
                    Console.WriteLine("3. Illustrate Hashtable");
                    Console.WriteLine("4. Swap 2 value with Generics");
                    Console.WriteLine("5. Demo Collections");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter your choice: ");
                    var choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            bool Exit = false;
                            while (!Exit)
                            {
                                Console.WriteLine("===========MENU===========");
                                Console.WriteLine("1. Add");
                                Console.WriteLine("2. Subtract");
                                Console.WriteLine("3. Multiply");
                                Console.WriteLine("4. Divide");
                                Console.WriteLine("5. Back to Menu");
                                Console.Write("Enter your choice: ");
                                choice = int.Parse(Console.ReadLine());
                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine("*****Add*****");
                                        Console.Write("Num 1: ");
                                        var a = Input<double>();
                                        Console.Write("Num 2: ");
                                        var b = Input<double>();
                                        Console.WriteLine($"Result: {Operator<double>.Add(a, b)}");
                                        break;
                                    case 2:
                                        Console.WriteLine("*****Subtract*****");
                                        Console.Write("Num 1: ");
                                        a = Input<double>();
                                        Console.Write("Num 2: ");
                                        b = Input<double>();
                                        Console.WriteLine($"Result: {Operator<double>.Subtract(a, b)}");
                                        break;
                                    case 3:
                                        Console.WriteLine("*****Multiply*****");
                                        Console.Write("Num 1: ");
                                        a = Input<double>();
                                        Console.Write("Num 2: ");
                                        b = Input<double>();
                                        Console.WriteLine($"Result: {Operator<double>.Multiply(a, b)}");
                                        break;
                                    case 4:
                                        Console.WriteLine("*****Divide*****");
                                        Console.Write("Num 1: ");
                                        a = Input<double>();
                                        Console.Write("Num 2: ");
                                        b = Input<double>();
                                        Console.WriteLine($"Result: {Operator<double>.Divide(a, b)}");
                                        break;
                                    case 5:
                                        Exit = true;
                                        break;
                                }
                            }
                            break;

                        case 2:
                            Console.Write("Illustrate Arraylist: ");
                            ArrayList arrayList = new ArrayList();
                            arrayList.Add("Item1");
                            arrayList.Add("Item2");
                            arrayList.Add("Item3");
                            arrayList.Add("Item4");
                            arrayList.Add("Item5");
                            foreach (var i in arrayList)
                            {
                                Console.Write(i + " ");
                            }
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Illustrate Hashtable: ");
                            Hashtable hashtable = new Hashtable();
                            hashtable.Add("1", "Spring");
                            hashtable.Add("2", "Summer");
                            hashtable.Add("3", "Fall");
                            hashtable.Add("4", "Winter");
                            Console.WriteLine("Key and Value: ");
                            foreach (DictionaryEntry i in hashtable)
                            {
                                Console.WriteLine(i.Key + " " + i.Value);
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Swap 2 value: ");
                            Console.Write("Number 1: ");
                            var num1 = Input<int>();
                            Console.Write("Numer 2: ");
                            var num2 = Input<int>();
                            Swap<int>(ref num1, ref num2);
                            Console.WriteLine("After Swap");
                            Console.WriteLine($"Number 1: {num1}");
                            Console.WriteLine($"Number 2: {num2}");
                            break;
                        case 5:
                            List<Person> people = new List<Person>()
                            {
                                new Person() { FirstName = "David1", LastName = "Simpson 1", Age = 34 },
                                new Person() { FirstName = "David2", LastName = "Simpson 2", Age = 42 },
                                new Person() { FirstName = "David3", LastName = "Simpson 3", Age = 45 },
                                new Person() { FirstName = "David4", LastName = "Simpson 4", Age = 39 },
                                new Person() { FirstName = "David5", LastName = "Simpson 5", Age = 50 },
                            };

                            //Demo List
                            Console.WriteLine("Demo List");
                            Console.WriteLine("Items in list: {0}", people.Count);
                            foreach (Person person in people)
                            {
                                Console.WriteLine(person);
                            }
                            Console.ReadLine();

                            //Demo SortedSet
                            Console.WriteLine("Demo SortedSet");
                            SortedSet<Person> people1 = new SortedSet<Person>();
                            foreach (Person person in people)
                            {
                                people1.Add(person);
                            }
                            Console.WriteLine("Elements of people1: \n");
                            foreach (var person in people1)
                            {
                                Console.WriteLine($"{person,3}");
                            }
                            Console.ReadLine();

                            //Demo IEnumerator
                            Console.WriteLine("Demo IEnumerator");
                            MyCollection<Person> myCollection = new MyCollection<Person>();
                            foreach (Person person in people)
                            {
                                myCollection.AddItem(person);
                            }
                            foreach (var person in myCollection)
                            {
                                Console.WriteLine(person);
                            }
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
