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
        Book curBook;

        FlipPageHandler fpHand;

        BookMkHandler bmHand;

        DisplayPageHandler dpHand;

        public BookView()
        {
            InitializeComponent();

            dpHand = curBook.DisplayPage;
        }
    
        
        public void Refresh()
        {
            dpHand();
        }
    }
}
