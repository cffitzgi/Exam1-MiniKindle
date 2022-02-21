using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1_MiniKindle
{
    public delegate void FlipPageHandler(bool dir);

    public delegate void RefresherDel();

    public delegate void BookMkHandler();

    public delegate String DisplayPageHandler();

    // New Delegate
    public delegate bool CurrentPageMarkedHandler();

    public delegate String GetTitleAuthorHandler();

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Windows Forms Stuff
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creates controller.
            Controller controller = new Controller();
            
            // Loads books into library
            controller.LoadLibrary("Books");

            LibraryView libView = new LibraryView();
//TODO: Instantiate LibraryView, set it's controller, 

            // Debugging purposes
            Book book = new Book();
            book.LoadBook("Books/BookOne-AuthorPerson.txt");

            controller.SelectBook(book);

            BookView bookView = new BookView(controller);

            bookView.RefreshPage();

            Application.Run(bookView);
        }
    }
}
