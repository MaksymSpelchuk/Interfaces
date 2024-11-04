using System;


    public interface IPrintable
    {
        void Print();
    }

    public interface IBorrowable
    {
        void BorrowItem();
        void ReturnItem();
        bool IsAvailable();
    }

    public class Book : IPrintable, IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        private bool isAvailable;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            isAvailable = true; 
        }

        public void Print()
        {
            Console.WriteLine($"Назва: {Title}, Автор: {Author}, Рік видання: {Year}, Доступність: {(isAvailable ? "Доступна" : "Недоступна")}");
        }

        public void BorrowItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"{Title} була взята з бібліотеки.");
            }
            else
            {
                Console.WriteLine($"{Title} недоступна для взяття.");
            }
        }

        public void ReturnItem()
        {
            if (!isAvailable)
            {
                isAvailable = true;
                Console.WriteLine($"{Title} була повернена в бібліотеку.");
            }
            else
            {
                Console.WriteLine($"{Title} вже є в бібліотеці.");
            }
        }

        public bool IsAvailable()
        {
            return isAvailable;
        }
    }

    public class LibraryTest
    {
        public static void Main()
        {
            Book book1 = new Book("Майстер і Маргарита", "Михайло Булгаков", 1967);
            Book book2 = new Book("Неймовірна подорож", "Жуль Верн", 1873);
            Book book3 = new Book("Війна і мир", "Лев Толстой", 1869);

            book1.Print();
            book1.BorrowItem();
            Console.WriteLine($"Доступність книги '{book1.Title}': {book1.IsAvailable()}");
            book1.Print();

            Console.WriteLine();

            book2.Print();
            book2.BorrowItem();
            book2.ReturnItem();
            Console.WriteLine($"Доступність книги '{book2.Title}': {book2.IsAvailable()}");
            book2.Print();

            Console.WriteLine();

            book3.Print();
            book3.BorrowItem();
            Console.WriteLine($"Доступність книги '{book3.Title}': {book3.IsAvailable()}");
            book3.Print();
        }
    }


