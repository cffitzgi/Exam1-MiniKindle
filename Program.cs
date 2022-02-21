using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1_MiniKindle
{
    public delegate void FlipPageHandler(bool dir);

    public delegate void BookMkHandler();

    public delegate String DisplayPageHandler();

    public delegate bool CurrentPageMarkedHandler();

    public delegate String GetTitleAuthorHandler();

    public delegate List<String> DisplayLibraryHandler();

    public delegate void SelectBookHandler(int i);

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

            DisplayPageHandler dpHand = controller.DisplayPage;
            GetTitleAuthorHandler taHand = controller.GetBookTitleAuthor;
            FlipPageHandler fpHand = controller.FlipPage;
            BookMkHandler bmHand = controller.Bookmark;
            CurrentPageMarkedHandler cpmHand = controller.CurrentPageMarked;
            DisplayLibraryHandler dlHand = controller.DisplayLibrary;
            SelectBookHandler sbHand = controller.SelectBook;


            // Loads books into library
            controller.LoadLibrary("Books");

            LibraryView libView = new LibraryView(dpHand, taHand, fpHand, bmHand, cpmHand, dlHand, sbHand);


            /* Debugging purposes
            Book book = new Book();
            book.LoadBook("Books/BookOne-AuthorPerson.txt");

            controller.SelectBook(book);

            BookView bookView = new BookView(controller);

            bookView.RefreshPage();
            //*/

            Application.Run(libView);
        }
    }
}
