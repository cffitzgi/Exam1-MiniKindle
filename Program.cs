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

    public delegate int GetCurrentPageHandler();

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

            // Delegates for days
            // BookView Delegates
            DisplayPageHandler dpHand = controller.DisplayPage;
            GetTitleAuthorHandler taHand = controller.GetBookTitleAuthor;   // Also used by LibraryView
            FlipPageHandler fpHand = controller.FlipPage;
            BookMkHandler bmHand = controller.Bookmark;
            CurrentPageMarkedHandler cpmHand = controller.CurrentPageMarked;
            GetCurrentPageHandler cpHand = controller.GetCurrentPage;

            // LibraryView Delegates
            DisplayLibraryHandler dlHand = controller.DisplayLibrary;
            SelectBookHandler sbHand = controller.SelectBook;


            // Loads books into library
            controller.LoadLibrary("Books");

            LibraryView libView = new LibraryView(dpHand, taHand, fpHand, bmHand, cpmHand, cpHand, dlHand, sbHand);

            Application.Run(libView);
        }
    }
}
