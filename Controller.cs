using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_MiniKindle
{
    public class Controller
    {
        private Library library;

        private Book currBook;

        public Controller()
        {
            library = new Library();
        }

        /// <summary>
        /// Gets the current page of selected book.
        /// </summary>
        /// <returns>Page as a string.</returns>
        public String DisplayPage()
        {
            return currBook.DisplayPage();
        }

        /// <summary>
        /// Gets the Title and Author of the book.
        /// </summary>
        /// <returns>Title by Author as String</returns>
        public String GetBookTitleAuthor()
        {
            return currBook.ToString();
        }

        /// <summary>
        /// Flips page respective to direction.
        /// </summary>
        /// <param name="dir">True goes forward, false goes backward</param>
        public void FlipPage(bool dir)
        {
            currBook.FlipPage(dir);
        }

        /// <summary>
        /// Toggles bookmark for current page.
        /// </summary>
        public void Bookmark()
        {
            currBook.AddRemBkMk();
        }

        public int GetCurrentPage()
        {
            return currBook.GetCurrentPage();
        }

        /// <summary>
        /// Checks whether the current page is already bookmarked.
        /// </summary>
        /// <returns></returns>
        public bool CurrentPageMarked()
        {
            return currBook.CurrentPageMarked();
        }

        /// <summary>
        /// Sets current book respective to library selection.
        /// </summary>
        /// <param name="i"></param>
        public void SelectBook(int i)
        {
            currBook = library.SelectBook(i);
        }

        /// <summary>
        /// Loads the books in the path directory into the library instance.
        /// </summary>
        /// <param name="path">Directory where books are located relative to execution.</param>
        public void LoadLibrary(String path)
        {
            library.LoadLibrary(path);
        }

        /// <summary>
        /// Gets the book titles contained within the library instance.
        /// </summary>
        /// <returns>List of Book titles and authors as strings.</returns>
        public List<String> DisplayLibrary()
        {
            return library.Display();
        }

    }
}
