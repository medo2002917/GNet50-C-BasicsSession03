using System.Text;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01
            {
                string lowerTitle = "clean code";
                string upperTitle = lowerTitle.ToUpper();

                Console.WriteLine(lowerTitle);
                Console.WriteLine(upperTitle);
            }

            // Q02
            string firstTitle = "Clean Code";
            string secondTitle = "Clean Code";
            Console.WriteLine(object.ReferenceEquals(firstTitle, secondTitle));

            // Q03
            StringBuilder bookText = new StringBuilder();
            bookText.Append("Book List");
            bookText.Append(" - Updated");
            Console.WriteLine(bookText.ToString());

            // Q04
            bookText.Replace("Book List", "Library");
            Console.WriteLine(bookText.ToString());

            // Q05
            string title = "Clean Code";
            int pages = 464;

            Console.WriteLine("Book: " + title + ", Pages: " + pages);

            // Q06
            Console.WriteLine($"Book: {title}, Pages: {pages}");

            // Q07
            Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));

            // Q08
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            // Q09
            bool isAvailable = true;
            if (pages > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }


        }
    }
}
