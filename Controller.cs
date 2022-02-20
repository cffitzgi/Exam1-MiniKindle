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

        private RefresherDel refresherDel;

        private DisplayPageHandler dpHand;

        public Controller()
        {
            dpHand = currBook.DisplayPage;
        }

        public void FlipPage(bool dir)
        {
            currBook.FlipPage(dir);
        }

        public void BookMark(int p)
        {
            currBook.AddRemBkMk(p);
        }

        public void SelectBook(int i)
        {
            library.SelectBook(i);
        }

    }
}
