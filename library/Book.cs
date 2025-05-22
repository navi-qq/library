using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Book
    {

        private String title;
        private String author;
        private int numberOfPages;
        private bool readingStatus;


        public Book(string title, string author, int numberOfPages, bool readingStatus)
        {
            this.title = title;
            this.author = author;
            this.numberOfPages = numberOfPages;
            this.readingStatus = readingStatus;
        }

        public void setReadingStatus(bool newReadigStatus)
        {
            this.readingStatus = newReadigStatus;
        }

        public string GetTitle()
        {
            return title;
        }

   
        public string GetAuthor()
        {
            return author;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }


        public bool GetReadingStatus()
        {
            return readingStatus;
        }

        public Book getBook()
        {
            return new Book(this.title, this.author, this.numberOfPages, this.readingStatus);
        }
        public void edit(string editedTitle, string editedAuthor, int editedNumberOfPages, bool editedReadingStatus)
        {
            this.title = editedTitle;
            this.author = editedAuthor;
            this.numberOfPages = editedNumberOfPages;
            this.readingStatus = editedReadingStatus;
        }
    }
}
