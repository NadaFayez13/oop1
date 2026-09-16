using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop_1
{
    //public enum Genre
    //{
    //    Fiction,
    //    NonFiction,
    //    Science
    //}
    //public class Book
    //{
    //    public string Title { get; set; }
    //    public Genre Genre { get; set; }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //sheet5
            #region question 4
            //Book book = new Book();
            //book.Title = "Science book";
            //book.Genre = Genre.Science;
            //Console.WriteLine($"Title: {book.Title}");
            //Console.WriteLine($"Genre: {book.Genre}");
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
            //string genreText = "Science";
            //Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine($"genre: {genre}");
            #endregion

            #region question 8
            /*Given string genreText = "Mystery"; (not a valid Genre value), use
            Enum.TryParse() to attempt the conversion. Print "Unknown genre" if it fails.*/
            //string genreText = "Mystery";
            //if (Enum.TryParse(genreText, out Genre genre))
            //{
            //    Console.WriteLine($"genre: {genre}");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}
            #endregion

            //sheet6 Theoretical Questions
            #region Theoretical Question 1
            //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?

            /*Since DeliveryAddress is a struct, copying it to another variable creates an independent copy of the data on the stack.
              Therefore, any changes made to the new variable will not affect the original one at all, 
             as they point to two separate memory locations.*/

            //b) What happens when a Customer variable is copied into another variable and one variable modifies the object
            /*Since Customer is a class, copying the variable copies only its memory reference, so both variables point to the same object on the heap. 
             * Modifying the object through one variable will affect the other.*/
            #endregion

            #region Theoretical Question 2
            //a) Identify at least three problems with this design from an encapsulation perspective.

            /* 1.Fields are public, which breaks encapsulation by letting outside code access them directly
               2. No Data Validation,Anyone can pass invalid values, like negative numbers for Weight or DeliveryFee
               3. no Control over Changes< There's no way to make fields read-only or prevent unwanted modifications from outside
             */
            //b) How can private fields and public properties improve this design?

            /* 1.making fields private hides the internal data from direct access
             2.public properties allow us to add checks(in setters) to prevent invalid values before saving them
             3.properties give us flexibility to make fields read-only or restrict how they are updated */
            #endregion

            //sheet6 Practical Questions
            #region Question 1

            //DeliveryAddress address1 = new DeliveryAddress("Alex", "gamal abdelnasser", 13);

            //DeliveryAddress address2 = address1;

            //address2.City = "cairo";
            //address2.BuildingNumber = 11;

            //Console.WriteLine($"address1: {address1.GetFullAddress()}");
            //Console.WriteLine($"address2: {address2.GetFullAddress()}");

            #endregion

            #region Question 6 points b
            //Shipment[] shipments = new Shipment[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Shipment {i + 1} Data");

            //    Console.Write("Tracking Code: ");
            //    string code = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string desc = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    double weight = double.Parse(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal fee = decimal.Parse(Console.ReadLine());

            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int bNum = int.Parse(Console.ReadLine());

            //    DeliveryAddress addr = new DeliveryAddress(city, street, bNum);
            //    shipments[i] = new Shipment(code, desc, weight, fee, addr);

            //    Console.WriteLine("\nShipment added successfully.\n");
            //}
            #endregion

            #region Question 6 point d
            //Console.WriteLine("All Shipments");
            //for (int i = 0; i < shipments.Length; i++)
            //{
            //    shipments[i].PrintShipment();
            //}
            #endregion

            #region Question 6 point e,f,g
            //Console.Write("\nEnter a tracking code to search: ");
            //string searchCode = Console.ReadLine();

            //bool found = false;
            //for (int i = 0; i < shipments.Length; i++)
            //{
            //    if (shipments[i].GetTrackingCode().Equals(searchCode, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"Shipment found: {shipments[i].GetTrackingCode()} - {shipments[i].GetDescription()}");
            //        found = true;
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("Shipment not found.");
            //}
            #endregion

            #region Question 6 point h
            Console.WriteLine("\nStruct Copy Test ");
            DeliveryAddress originalAddr = new DeliveryAddress("alex", "fawzy moaaz Street", 15);
            DeliveryAddress copiedAddr = originalAddr;

            copiedAddr.Street = "port saied Street";
            copiedAddr.BuildingNumber = 20;

            Console.WriteLine($"Original Address: {originalAddr.GetFullAddress()}");
            Console.WriteLine($"Copied Address:   {copiedAddr.GetFullAddress()}");
            #endregion
        }
    }
}