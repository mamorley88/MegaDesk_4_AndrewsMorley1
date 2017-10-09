using Newtonsoft.Json;
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
    public partial class searchQuotes : Form
    {
        List<Desk.DesktopMaterial> materials;

        public searchQuotes()
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

            }
        private List<DeskQuote> deserialize()
        {
            var quotesList = new List<DeskQuote>();


            string path = ".\\quotes.json";

            if (!File.Exists(path))
            {
                return quotesList;
            }
            using (var rd = new StreamReader(path))
            {
                quotesList = JsonConvert.DeserializeObject<List<DeskQuote>>(rd.ReadToEnd()) as List<DeskQuote>;


            }
            return quotesList;
        }
        private void materialChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filter = (Desk.DesktopMaterial)materialChoice.SelectedValue;
            var deskQuotes = this.deserialize();
            foreach (DeskQuote quote in deskQuotes)
            {
                if (quote.desk.material != filter)
                { deskQuotes.Remove(quote); }
            }
            resultsGridView.DataSource = deskQuotes
                ;



        }
    }
}
