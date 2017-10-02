using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MarcoMorley1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

       /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            addQuote1 addQuote = new addQuote1();
            addQuote.Show();
        }
        // Create addquote.
        public class addQuote1 : Form
        {
            public addQuote1()
            {
                Text = "addQuote";
            }
        }*/
        
        
        private void addNewQuote_Click_1(object sender, EventArgs e)
        {
            addQuote1 addQuote = new addQuote1();
            //this.Hide();
            addQuote.Show();
           
        }

        private void viewQuote1_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewquotes= new ViewAllQuotes();
            //this.Hide();
            viewquotes.Show();
        }
    }
}