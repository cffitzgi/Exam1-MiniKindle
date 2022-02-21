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
        //private Library library;
        private Controller controller;

        private BookView bookView;

        BookMkHandler bookHand;

        public LibraryView()
        {
            InitializeComponent();
        }

        public LibraryView(Controller c)
        {
            InitializeComponent();

            controller = c;
            List<String> books = c.DisplayLibrary();
            foreach(string t in books)
                listViewBooks.Items.Add(t);
        }

        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SelectBook(listViewBooks.SelectedItems.IndexOf(listViewBooks.SelectedItems[0]));
            bookView.labelPageDisplay =  controller.DisplayPage();
        }
    }
}
