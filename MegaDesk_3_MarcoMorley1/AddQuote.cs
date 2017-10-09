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
using Newtonsoft.Json;

namespace MegaDesk_3_MarcoMorley1
{


    public partial class addQuote1 : Form
    {

        object parent = null;
        List<Desk.DesktopMaterial> materials;
        List<DeskQuote.RUSH> rushOptions;

        public addQuote1()
        {
            InitializeComponent();
            materials = new List<Desk.DesktopMaterial>()
            {
                Desk.DesktopMaterial.LAMINATE,
                Desk.DesktopMaterial.OAK,
                Desk.DesktopMaterial.PINE,
                Desk.DesktopMaterial.ROSEWOOD,
                Desk.DesktopMaterial.VENEER
            };
            materialChoice.DataSource = materials;


            rushOptions = new List<DeskQuote.RUSH>()
            {
                DeskQuote.RUSH.NO_RUSH,
                DeskQuote.RUSH.THREE,
                DeskQuote.RUSH.FIVE,
                DeskQuote.RUSH.SEVEN

            };
            rushOrderDays.DataSource = rushOptions;

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
            DeskQuote[] quotes = this.deserialize();

            DeskQuote deskQuote = this.serialize(quotes);
            DisplayQuote dq = new DisplayQuote();
            dq.Initialize(deskQuote);
            dq.ShowDialog();

        }
        private DeskQuote[] deserialize()
        {
            var quotesList = new List<DeskQuote>();
           

            string path = ".\\quotes.json";

            if (!File.Exists(path))
            {
                return quotesList.ToArray();
            }
            using (var rd = new StreamReader(path))
            {
               quotesList= JsonConvert.DeserializeObject<List<DeskQuote>>(rd.ReadToEnd()) as List<DeskQuote>;

               
            }
            return quotesList.ToArray();
        }
        private DeskQuote serialize(DeskQuote[] quotes)

        {
            string path = ".\\quotes.json";
            int width = Convert.ToInt32(Math.Round(this.widthInput.Value, 0));
            int depth = Convert.ToInt32(Math.Round(this.depthInput.Value, 0));
            int drawers = Convert.ToInt32(Math.Round(this.numDrawers.Value, 0));
            Desk desk = new Desk(width, depth, drawers, (Desk.DesktopMaterial)materialChoice.SelectedValue);
            DeskQuote current = new DeskQuote(this.nameBox.Text, (int)this.rushOrderDays.SelectedValue, desk);
           
          
            using (var w = new StreamWriter(path))
            {
                List<DeskQuote> deskQuoteList = new List<DeskQuote>();
                foreach (DeskQuote quote in quotes)
                {
                    deskQuoteList.Add(quote);
                }
                deskQuoteList.Add(current);
                var json = JsonConvert.SerializeObject(deskQuoteList);
                w.WriteLine (json.ToString());
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
                depthError.Text = "Invalid Integer";
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

   
