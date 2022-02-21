using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1_MiniKindle
{
    public partial class LibraryView : Form
    {
        private BookView bookView;

        private DisplayPageHandler dpHand;

        private GetTitleAuthorHandler taHand;

        private FlipPageHandler fpHand;

        private BookMkHandler bmHand;

        private CurrentPageMarkedHandler cpmHand;

        private GetCurrentPageHandler cpHand;

        private DisplayLibraryHandler dlHand;

        private SelectBookHandler sbHand;


        public LibraryView(DisplayPageHandler dp, GetTitleAuthorHandler ta, FlipPageHandler fp, BookMkHandler bm, CurrentPageMarkedHandler cpm, GetCurrentPageHandler cp,
            DisplayLibraryHandler dl, SelectBookHandler sb)
        {
            InitializeComponent();

            dpHand = dp;
            taHand = ta;
            fpHand = fp;
            bmHand = bm;
            cpmHand = cpm;
            cpHand = cp;
            dlHand = dl;
            sbHand = sb;

            List<String> books = dlHand();
            foreach(string t in books)
                listViewBooks.Items.Add(t);
        }

        /// <summary>
        /// Handles when a Library selection is made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 0) return;

            sbHand(listViewBooks.Items.IndexOf(listViewBooks.SelectedItems[0]));
            bookView = new BookView(dpHand, taHand, fpHand, bmHand, cpmHand, cpHand);
            bookView.RefreshPage();
            bookView.ShowDialog();

        }
    }
}
