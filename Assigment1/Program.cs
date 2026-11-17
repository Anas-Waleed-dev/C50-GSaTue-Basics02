namespace Assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Q1.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a
            // variable of type object.Print it
            // Book book = new Book();
            //book.Title = "Book1";
            //book.Pages = 100;
            //object obj = book;
            //Console.WriteLine(obj);
            #endregion
            #region Question 2

            //2.Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            // itself), GetHashCode(), and GetType() on book.
            //    Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //    Console.WriteLine(book.GetType());
            //    Console.WriteLine(book.ToString());

            #endregion
            #region Question 3
            //Q03.  Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            // int pages = "464";
            /*
            int pages = "464";
            Syntax Error
           Compile time Error
            */
            #endregion

            #region Question 4
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block.
            //int num = 10;
            //int num2 = 0;

            //try
            //{
            //    int result = num / num2;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Not Divide By Zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("Please enter your numbers Bigger than zero,Done");
            //}
            #endregion
            #region Question 5
            //Q05.  Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double pages2 = pages;
            //Console.WriteLine(pages2);
            #endregion
            #region Question 6
            //Q06.  Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;

            //int price2 = (int)price;
            //Console.WriteLine(price2);
            #endregion
            #region Question 7
            //Q07.  Given string pagesText = "464";, convert it into an int using the Convert class.
            string pagesText = "464";
            int Result = Convert.ToInt32(pagesText);
            Console.WriteLine(Result);
            #endregion

            #region Question 8
            //Q08.  Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            // use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            ////Parse
            //string yearText = "2023";
            //int Result1 = int.Parse(yearText);
            //Console.WriteLine(Result1);

            ////TryParse
            //string badText = "abc";
            //bool Result2 = int.TryParse(badText, out int number);
            //if (Result2)
            //    Console.WriteLine($"Succes,{number}");
            //else
            //    Console.WriteLine("Invalid number");

            #endregion
            #region Question 9
            //Q09.  Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            // to prove it's now a string.
            int pages1 = 464;
            string Result3 = pages1.ToString();
            Console.WriteLine(Result3);
            Console.WriteLine(Result3.GetType());
            #endregion
        }
    }
}
