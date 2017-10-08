using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MegaDesk_3_MarcoMorley1;

namespace MegaDesk_3_MarcoMorley1
{


    public partial class addQuote1 : Form
    {

        object parent = null;

        public addQuote1()
        {
            InitializeComponent();

        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            this.Hide();
            addQuote1 f2 = new addQuote1();
            f2.ShowDialog(); // Shows Add Quote input form
            this.parent = sender;
        }


        private void saveText_Click(object sender, EventArgs e)
        {
            DeskQuote[] quotes = this.readFromCsv();

            DeskQuote deskQuote = this.saveToCsv(quotes);
            DisplayQuote dq = new DisplayQuote();
            dq.Initialize(deskQuote);
            dq.ShowDialog();

        }
        private DeskQuote[] readFromCsv()
        {
            var quotesList = new List<DeskQuote>();
            string path = ".\\quotes.txt";
            if (!File.Exists(path))
            {
                return quotesList.ToArray();
            }
            using (var rd = new StreamReader(path))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(',');
                    int width = Convert.ToInt32(splits[1]);
                    int depth = Convert.ToInt32(splits[2]);
                    int drawers = Convert.ToInt32(splits[3]);

                    Desk.MATERIALS material = (Desk.MATERIALS)Convert.ToInt32(splits[4]);
                    DeskQuote.RUSH rush = (DeskQuote.RUSH)Convert.ToInt32(splits[5]);
                    double price = Convert.ToDouble(splits[6]);
                    DateTime date = DateTime.Parse(splits[7]);
                    DeskQuote current = new DeskQuote(splits[0], (int)rush);
                    current.price = price;
                    current.date = date;
                    quotesList.Add(current);

                }
            }
            return quotesList.ToArray();
        }
        private DeskQuote saveToCsv(DeskQuote[] quotes)

        {
            string path = ".\\quotes.txt";
            int width = Convert.ToInt32(Math.Round(this.widthInput.Value, 0));
            int depth = Convert.ToInt32(Math.Round(this.depthInput.Value, 0));
            int drawers = Convert.ToInt32(Math.Round(this.numDrawers.Value, 0));
            DeskQuote current = new DeskQuote(this.nameBox.Text, this.rushOrderDays.SelectedIndex);

            using (var w = new StreamWriter(path))
            {
                /*string header = "name,width, depth, drawers, material, rush, price, date";
                w.WriteLine(header);
                w.Flush();*/
                foreach (DeskQuote quote in quotes)
                {

                    var line = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                        quote.name, quote.desk.width, quote.desk.depth, quote.desk.drawers,
                       quote.desk.material, quote.rush, quote.price, quote.date.ToString("yyyy-MM-dd HH:mm:ss tt"));
                    w.WriteLine(line);
                    w.Flush();
                }

                var currentline = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                      current.name, current.desk.width, current.desk.depth, current.desk.drawers,
                      current.desk.material, current.rush, current.price, current.date.ToString(""));
                w.WriteLine(currentline);
                w.Flush();
            }
            return current;

        }
        private void validateWidth()
        {

            String result = widthInput.Value.ToString();
            if (result.IndexOf('.') >= 0)
            {
                widthError.Text = "Invalide Integer";
                return;
            }
            widthError.Text = Desk.validateWidth((int)widthInput.Value);
        }
        private void widthInput_KeyUp(object sender, KeyEventArgs e)
        {
            validateWidth();
        }
        private void widthInput_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                validateWidth();
            }
        }
        private void validateDepth()
        {
            String result = depthInput.Value.ToString();
            if (result.IndexOf('.') >= 0)
            {
                depthError.Text = "Invalide Integer";
                return;
            }
            depthError.Text = Desk.validateDepth((int)depthInput.Value);
        }


        private void depthInput_KeyUp(object sender, KeyEventArgs e)
        {
            validateDepth();

        }

        private void depthInput_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                validateDepth();
            }
        }
    }


    }

   
