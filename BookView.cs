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

        private FlipPageHandler fpHand;

        private BookMkHandler bmHand;

        private DisplayPageHandler dpHand;

        private CurrentPageMarkedHandler cpmHand;

        private GetCurrentPageHandler cpHand;

        private GetTitleAuthorHandler taHand;


        public BookView(DisplayPageHandler dp, GetTitleAuthorHandler ta, FlipPageHandler fp, BookMkHandler bm, CurrentPageMarkedHandler cpm, GetCurrentPageHandler cp)
        {
            InitializeComponent();

            dpHand = dp;
            taHand = ta;
            fpHand = fp;
            bmHand = bm;
            cpmHand = cpm;
            cpHand = cp;
        }
        
        /// <summary>
        /// Refreshes the page to reflect user interaction (and upon loading).
        /// </summary>
        public void RefreshPage()
        {
            this.Text = taHand();

            labelPageDisplay.Text = dpHand();
            labelPageNumber.Text = "Page " + cpHand();

            if (cpmHand())
                buttonBookmark.Text = "Unbookmark";
            else
                buttonBookmark.Text = "Bookmark";
        }

        /// <summary>
        /// Button event handler for flipping forward a page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            fpHand(true);
            RefreshPage();
        }

        /// <summary>
        /// Button event handler for flipping back a page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            fpHand(false);
            RefreshPage();
        }

        /// <summary>
        /// Button event handler for setting a bookmark at that page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBookmark_Click(object sender, EventArgs e)
        {
            bmHand();
            RefreshPage();
        }
    }
}
