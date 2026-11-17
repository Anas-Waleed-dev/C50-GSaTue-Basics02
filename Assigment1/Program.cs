namespace Assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Q1.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a
            // variable of type object.Print it
            Book book = new Book();
            book.Title = "Book1";
            book.Pages = 100;
            object obj = book;
            Console.WriteLine(obj);
            #endregion

        }
    }
}
