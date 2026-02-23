using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLibrary : Form
    {
        public frmLibrary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUserO frmUserO = new frmUserO();
            frmUserO.ShowDialog();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmBookO frmBookO = new frmBookO();
            frmBookO.ShowDialog();
        }

        private void frmBookInquiry_Click(object sender, EventArgs e)
        {
            frmBookInquiry frmBookInquiry = new frmBookInquiry();
            frmBookInquiry.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmReturnBooks frmReturnBooks = new frmReturnBooks();
            frmReturnBooks.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmReserveBook frmReserveBook = new frmReserveBook();
          frmReserveBook.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmloanbook frmloanbook = new frmloanbook();
            frmloanbook.ShowDialog();
        }

    }
}
