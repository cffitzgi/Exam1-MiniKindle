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

        public BookView()
        {
            InitializeComponent();

            dpHand = controller.DisplayPage;
            fpHand = curBook.FlipPage;
            bmHand = curBook.AddRemBkMk;
        }
        
        public void SetController(Controller c)
        {
            controller = c;
        }
        
        public void Refresh()
        {
            PageDisplay.Text = dpHand();
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            fpHand(true);
        }
    }
}
