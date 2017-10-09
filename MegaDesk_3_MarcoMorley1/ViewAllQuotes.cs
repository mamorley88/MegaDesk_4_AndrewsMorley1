using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MarcoMorley1
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            string path = ".\\quotes.json";
            if (!File.Exists(path))
            {
                return; 
                    }
            this.richTextBox.Text = File.ReadAllText(path);

        }
    }
}
