using System;
using static System.Console;

namespace FineForOverDueBooks
{
    class Program
    {
        private static void DisplayFind(int books, int days)
        {
            const double FINE1 = 0.1;
            const double FINE2 = 0.2;
            const int DAY_FINE_INCREASES = 7;
            double fine;

            if (days <= DAY_FINE_INCREASES)
                fine = books * days * FINE1;
            else
                fine = books * FINE1 * DAY_FINE_INCREASES + books * FINE2 * (days - DAY_FINE_INCREASES);
            WriteLine("The fine for {0} books for {1} day(s) is going to be {2}: ", books, days, fine.ToString("C"));
        }
        static void Main(string[] args)
        {
            int books;
            int days = 0;
            WriteLine("enter the number of books that are overdue: ");
            books = Convert.ToInt32(ReadLine());

            WriteLine("Enter number of days that the {0} books are overdue: ", books);
            days = Convert.ToInt32(ReadLine());

            DisplayFind(books, days);
        }
    }
}
