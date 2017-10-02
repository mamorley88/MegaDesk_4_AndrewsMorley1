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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }
        public void Initialize(DeskQuote dq)
        {
            this.nameText.ReadOnly = false;
            this.nameText.SelectedText = dq.name;
            this.nameText.ReadOnly = true;

            this.widthText.ReadOnly = false;
            this.widthText.SelectedText = dq.width.ToString();
            this.widthText.ReadOnly = true;

            this.depthText.ReadOnly = false;
            this.depthText.SelectedText = dq.depth.ToString();
            this.depthText.ReadOnly = true;

            this.drawerText.ReadOnly = false;
            this.drawerText.SelectedText = dq.drawers.ToString();
            this.drawerText.ReadOnly = true;

            this.materialText.ReadOnly = false;
            this.materialText.SelectedText = dq.getMaterial();
            this.materialText.ReadOnly = true;

            this.rushText.ReadOnly = false;
            this.rushText.SelectedText = dq.getRush();
            this.rushText.ReadOnly = true;

            this.priceText.ReadOnly = false;
            this.priceText.SelectedText = "$ " + dq.price.ToString();
            this.priceText.ReadOnly = true;

            this.dateText.ReadOnly = false;
            this.dateText.SelectedText = dq.date.ToString("yyyy-MM-dd HH:mm:ss tt");
            this.dateText.ReadOnly = true;
        }
       

        
    }

}


