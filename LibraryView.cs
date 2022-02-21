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

        DisplayPageHandler dpHand;

        GetTitleAuthorHandler taHand;

        FlipPageHandler fpHand;

        BookMkHandler bmHand;

        CurrentPageMarkedHandler cpmHand;

        DisplayLibraryHandler dlHand;

        SelectBookHandler sbHand;


        public LibraryView(DisplayPageHandler dp, GetTitleAuthorHandler ta, FlipPageHandler fp, BookMkHandler bm, CurrentPageMarkedHandler cpm,
            DisplayLibraryHandler dl, SelectBookHandler sb)
        {
            InitializeComponent();

            dpHand = dp;
            taHand = ta;
            fpHand = fp;
            bmHand = bm;
            cpmHand = cpm;
            dlHand = dl;
            sbHand = sb;

            List<String> books = dlHand();
            foreach(string t in books)
                listViewBooks.Items.Add(t);
        }

        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 0) return;

            sbHand(listViewBooks.Items.IndexOf(listViewBooks.SelectedItems[0]));
            bookView = new BookView(dpHand, taHand, fpHand, bmHand, cpmHand);
            bookView.RefreshPage();
            bookView.ShowDialog();

        }
    }
}
