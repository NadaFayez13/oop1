using System.Drawing;

namespace oop_1
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    public class Book
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //sheet5
            #region question 4
            Book book = new Book();
            book.Title = "Science book";
            book.Genre = Genre.Science;
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Genre: {book.Genre}");
            #endregion



        }
    }
}