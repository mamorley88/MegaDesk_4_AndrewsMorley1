using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MarcoMorley1
{
    
    public class DeskQuote : Object
    {
        enum MATERIALS { LAMINATE = 0, OAK = 1, ROSEWOOD = 2, VENEER = 3, PINE = 4 };
        enum RUSH { NO_RUSH, THREE, FIVE, SEVEN };
        string name;
        int width;
        int depth;
        int drawers;
        MATERIALS material;
        RUSH rush;
        double price;
        DateTime date;
        double price_per_sqin = 1.00;

        public DeskQuote(string name, int width, int depth, int drawers, int material, int rush)
        {
            this.material = (MATERIALS)material;
            this.rush = (RUSH)rush;
            this.calculatePrice();
            this.date = DateTime.Now;
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
