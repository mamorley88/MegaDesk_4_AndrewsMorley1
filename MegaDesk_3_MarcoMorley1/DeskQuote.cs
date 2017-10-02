using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MarcoMorley1
{
    
    public class DeskQuote : Object
    {
        public enum MATERIALS { LAMINATE = 0, OAK = 1, ROSEWOOD = 2, VENEER = 3, PINE = 4 };
        public enum RUSH { NO_RUSH, THREE, FIVE, SEVEN };
        public string name;
        public int width;
        public int depth;
        public int drawers;
        public MATERIALS material;
        public RUSH rush;
        public double price;
        public DateTime date;
        double price_per_sqin = 1.00;

        public DeskQuote(string name, int width, int depth, int drawers, int material, int rush)
        {
            this.name = name;
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = (MATERIALS)material;
            this.rush = (RUSH)rush;
            try {
                this.calculatePrice();
            }
            catch (Exception exception)
            {

            }

            this.date = DateTime.Now;
        }

        public string getRush()
        {
            string rv = "";

            switch (this.rush)
            {
                case RUSH.NO_RUSH:
                    rv = "No Rush";
                    break;

                case RUSH.THREE:
                    rv = "3 days";
                    break;

                case RUSH.FIVE:
                    rv = "5 Days";
                    break;

                case RUSH.SEVEN:
                    rv = "7 Days";
                    break;

            }
            return rv;
        }
        public string getMaterial()
        {
            string rv = "";

            switch (this.material)
            {
                case MATERIALS.LAMINATE:
                    rv = "Laminate";
                    break;

                case MATERIALS.OAK:
                   rv = "Oak";
                    break;

                case MATERIALS.ROSEWOOD:
                    rv = "Rosewood";
                    break;

                case MATERIALS.VENEER:
                    rv = "Veneer";
                    break;

                case MATERIALS.PINE:
                    rv = "Pine";
                    break;

                
            }
            return rv;
        }

        private void calculatePrice()
        {
            this.price = 200.0;
            this.price += 50 * this.drawers;

            switch (this.material)
            {
                case MATERIALS.LAMINATE:
                    this.price += 100.0;
                    break;

                case MATERIALS.OAK:
                    this.price += 200.0;
                    break;

                case MATERIALS.ROSEWOOD:
                    this.price += 300.0;
                    break;

                case MATERIALS.VENEER:
                    this.price += 125.0;
                    break;

                case MATERIALS.PINE:
                    this.price += 50.0;
                    break;

                default:
                    throw new Exception("Invalid material selected");
            }

            int surfacearea = this.depth * this.width;

            if (surfacearea > 1000)
            {
                this.price += surfacearea * this.price_per_sqin;
            }
            switch (this.rush)
            {
                case RUSH.NO_RUSH:
                    break;

                case RUSH.THREE:
                    if (surfacearea < 1000)
                    {
                        this.price += 60.0;
                    }
                    else if (surfacearea < 2000)
                    {
                        this.price += 70.0;
                    }
                    else
                    {
                        this.price += 80.0;
                    }
                    break;

                case RUSH.FIVE:
                    if (surfacearea < 1000)
                    {
                        this.price += 40.0;
                    }
                    else if (surfacearea < 2000)
                    {
                        this.price += 50.0;
                    }
                    else
                    {
                        this.price += 60.0;
                    }
                    break;

                case RUSH.SEVEN:
                    if (surfacearea < 1000)
                    {
                        this.price += 30.0;
                    }
                    else if (surfacearea < 2000)
                    {
                        this.price += 35.0;
                    }
                    else
                    {
                        this.price += 40.0;
                    }

                    break;

            }


        }
    }

}
