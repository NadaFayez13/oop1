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

            #region question 5
            /*Using the Genre enum above, print the underlying int value Genre.Fiction,
           Genre.NonFiction, and Genre.Science by casting each to int.*/
            //int fictionValue = (int)Genre.Fiction;
            //int nonFictionValue = (int)Genre.NonFiction;
            //int scienceValue = (int)Genre.Science;

            //Console.WriteLine($"Genre.Fiction: {fictionValue}");
            //Console.WriteLine($"Genre.NonFiction: {nonFictionValue}");
            //Console.WriteLine($"Genre.Science: {scienceValue}");

            #endregion

            #region question 6
            // Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine($"Genre: {genre}");
            #endregion

            #region question 7
            /*Given string genreText = "Science";, convert it into a Genre value using
            Enum.Parse() and print the result.*/
            string genreText = "Science";
            Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine($"genre: {genre}");
            #endregion
        }
    }
}