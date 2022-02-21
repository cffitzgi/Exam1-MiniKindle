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
    public partial class BookView : Form
    {
        //TODO: Shouldn't we replace this with the Controller like in Lab03???
        //Book curBook;
        Controller controller;

        FlipPageHandler fpHand;

        BookMkHandler bmHand;

        DisplayPageHandler dpHand;


        // New Handlers Added
        CurrentPageMarkedHandler cpmHand;

        GetTitleAuthorHandler taHand;


        public BookView(Controller c)
        {
            InitializeComponent();

            controller = c;

            dpHand = controller.DisplayPage;
            taHand = controller.GetBookTitleAuthor;
            fpHand = controller.FlipPage;
            bmHand = controller.BookMark;
            cpmHand = controller.CurrentPageMarked;

        }
        
        
        public void RefreshPage()
        {
            this.Text = taHand();

            labelPageDisplay.Text = dpHand();

            if (cpmHand())
                buttonBookmark.Text = "Unbookmark";
            else
                buttonBookmark.Text = "Bookmark";
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            fpHand(true);
            RefreshPage();
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            fpHand(false);
            RefreshPage();
        }

        private void buttonBookmark_Click(object sender, EventArgs e)
        {
            bmHand();
            RefreshPage();
        }
    }
}
