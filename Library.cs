using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam1_MiniKindle
{
    public class Library
    {
        /// <summary>
        /// List containing books.
        /// </summary>
        private List<Book> library;

        public Library()
        {
            library = new List<Book>();
        }

        /// <summary>
        /// Loads the books contained in the path directory into this library instance.
        /// </summary>
        /// <param name="path">Directory where books are located.</param>
        public void LoadLibrary(String path)
        {
            String[] filenames = Directory.GetFiles(path);
            int n = 0;
            foreach (String fn in filenames)
            {
                if (n > 25) break;

                Book newBook = new Book();
                newBook.LoadBook(fn);
                library.Add(newBook);

                n++;
            }
        }

        /// <summary>
        /// Selects the book at the index given.
        /// </summary>
        /// <param name="i">Index of book to return.</param>
        /// <returns>Book object selected.</returns>
        public Book SelectBook(int i)
        {
            return library[i];
        }

        /// <summary>
        /// Returns a list of all the library's Book Title by Author.
        /// </summary>
        /// <returns>List of each Book's Title by Author.</returns>
        public List<String> Display()
        {
            List<string> listOfBookInfo = new List<string>();

            for (int i = 0; i < library.Count; i++)
            {
                listOfBookInfo.Add(library[i].ToString());
            }

            return listOfBookInfo;
        }


    }
}
