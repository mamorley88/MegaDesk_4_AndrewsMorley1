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
        Quote[] quotes ;


        public addQuote1()
        {
            InitializeComponent();

        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            this.Hide();
            addQuote1 f2 = new addQuote1();
            f2.ShowDialog(); // Shows Add Quote input form
        }

       
        private void saveText_Click(object sender, EventArgs e)
        {
            this.saveToCsv();

            
        }
        private void saveToCsv()

        {
            
            // Prepare the values
            //var allLines = (from trade in proposedTrades
            //                select new object[]
            //                {
            //        trade.TradeType.ToString(),
            //        trade.AccountReference,
            //        trade.SecurityCodeType.ToString(),
            //        trade.SecurityCode,
            //        trade.ClientReference,
            //        trade.TradeCurrency,
            //        trade.AmountDenomination.ToString(),
            //        trade.Amount,
            //        trade.Units,
            //        trade.Percentage,
            //        trade.SettlementCurrency,
            //        trade.FOP,
            //        trade.ClientSettlementAccount,
            //        string.Format("\"{0}\"", trade.Notes),
            //                }).ToList();

            //// Build the file content
            //var csv = new StringBuilder();
            //allLines.ForEach(line =>
            //{
            //    csv.AppendLine(string.Join(",", line));
            //});

            //File.WriteAllText(filePath, csv.ToString());

            //return rv;


        }


    }

   }
