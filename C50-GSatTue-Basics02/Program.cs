using System.Runtime.CompilerServices;

namespace C50_GSatTue_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a variable of type object.Print it.
            //Book book = new Book() {Title="C#",pages=250};
            //object ob = book;
            //Console.WriteLine(((Book)ob).Title);
            //Console.WriteLine(((Book)ob).pages);
            #endregion

            #region question 2
            //Q02.  Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            //Book book = new Book() { Title = "C#", pages = 250 };
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion

            #region question 3
            //Q03.  Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. int pages = "464";

            ///* compile-time error */
            //int pages = int.Parse("464"); //fixed
            #endregion

            #region question 4
            //Q04.  Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block
            //try
            //{
            //    int a = 10, b = 0;
            //    int result = a / b;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region question 5
            //Q05.  Declare an int pages = 300; then store it in a double variable without using a cast
            //int pages = 300;
            //double x = pages;
            //Console.WriteLine(x);
            #endregion

            #region question 6
            //Q06.  Declare a double price = 49.99; then convert it into an int using a cast
            double price = 49.99;
            int x = (int)price;
            Console.WriteLine(x);
            #endregion
        }
    }
}
