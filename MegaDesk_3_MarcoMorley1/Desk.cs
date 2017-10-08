using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MarcoMorley1
{
    public class Desk : Object

    {
        public int width;
        public int depth;
        public int drawers;
        public MATERIALS material;

        public enum MATERIALS { LAMINATE = 0, OAK = 1, ROSEWOOD = 2, VENEER = 3, PINE = 4 };
        public static int minWidth = 24;
        public static int maxWidth = 96;
        public static int minDepth = 24;
        public static int maxDepth = 96;
        


        public Desk(int width, int depth, int drawers, MATERIALS material)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = (MATERIALS)material;
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

        public static string validateWidth(int width)
        {
            if (width < minWidth)
            { return "Width too small"; }


            if (width > maxWidth)
            { return "Width too big"; }

            return "";

        }
        public static string validateDepth(int depth)
        {
            if (depth < minDepth)
            { return "Depth too small"; }


            if (depth > maxDepth)
            { return "Depth too big"; }

            return "";

        }
    }
}

