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

        FlipPageHandler fpHand;

        BookMkHandler bmHand;

        DisplayPageHandler dpHand;

        CurrentPageMarkedHandler cpmHand;

        GetTitleAuthorHandler taHand;


        public BookView(DisplayPageHandler dp, GetTitleAuthorHandler ta, FlipPageHandler fp, BookMkHandler bm, CurrentPageMarkedHandler cpm)
        {
            InitializeComponent();

            dpHand = dp;
            taHand = ta;
            fpHand = fp;
            bmHand = bm;
            cpmHand = cpm;
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
