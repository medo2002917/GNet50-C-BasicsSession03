using System.Text;

namespace Assignment2
{
    internal class Program
    {
        static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
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

            // Q10
            {
                string selectedTitle = "Refactoring";

                switch (selectedTitle)
                {
                    case "Clean Code":
                        Console.WriteLine("Great choice!");
                        break;
                    case "Refactoring":
                        Console.WriteLine("Nice pick!");
                        break;
                    default:
                        Console.WriteLine("Never heard of it");
                        break;
                }
            }

            // Q11
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);

            // Q12
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }

            // Q13
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }

            // Q14
            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            }
            while (count < 3);

            // Q15
            foreach (string bookName in books)
            {
                Console.WriteLine(bookName);
            }

            // Q16
            foreach (string bookName in books)
            {
                if (bookName == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(bookName);
            }

            // Q17
            foreach (string bookName in books)
            {
                if (bookName == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(bookName);
            }
        }
    }
}
