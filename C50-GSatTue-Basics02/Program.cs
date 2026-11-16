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

            /* compile-time error */
            int pages = int.Parse("464"); //fixed
            #endregion
}
}
}
