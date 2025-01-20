using System;

namespace _22_Library
{
    internal class Library
    {
        private Book[] bookList = new Book[1000]; 
        private int nrOfBooks = 0;

        public Library()
        {
            // Constructor logic can go here if needed
        }

        public void AddBook(Book book)
        {
            if (nrOfBooks < 1000)
            {
                bookList[nrOfBooks] = book; 
                nrOfBooks++;
            }
        }

        public void PrintBookList()
        {
            for (int i = 0; i < nrOfBooks; i++)
            {
                Console.WriteLine(bookList[i]);
            }
        }
        public void BorrowBook(Book book)
        {
            for(int i = 0;i < nrOfBooks;i++)
            {
                if (bookList[i] == book)
                {
                    bookList[i].Available = false;
                }
            }
        }
        public void ReturnBook(Book book)
        {
            for(int i = 0;i < nrOfBooks;i++)
            {
                if (bookList[i] == book)
                {
                    bookList[i].Available = true;
                }
            }
        }
        public void PrintAvailableBookList()
        {
            Console.WriteLine("Verfügbare Bücher");
            for (int i = 0;i < nrOfBooks; i++)
            {
                if (bookList[i].Available == true)
                {
                    Console.WriteLine(bookList[i].Info);
                }
            }
        }
        public void PrintBorrowedBookList()
        {

        }
    }
}
