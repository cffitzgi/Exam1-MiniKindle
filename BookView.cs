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

        BookMarkHandler bmHand;

        public BookView()
        {
            InitializeComponent();
        }
    
        
        public void Refresh()
        {

        }
    }
}
