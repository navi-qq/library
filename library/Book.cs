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

        public String title;
        public String author;
        public int numberOfPages;
        public bool readingStatus;


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

        public void edit(string editedTitle, string editedAuthor, int editedNumberOfPages, bool editedReadingStatus)
        {
            this.title = editedTitle;
            this.author = editedAuthor;
            this.numberOfPages = editedNumberOfPages;
            this.readingStatus = editedReadingStatus;
        }
    }
}
