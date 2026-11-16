namespace C50_GSatTue_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a variable of type object.Print it.
            Book book = new Book() {Title="C#",pages=250};
            object ob = book;
            Console.WriteLine(((Book)ob).Title);
            Console.WriteLine(((Book)ob).pages);
            #endregion
        }
    }
}
