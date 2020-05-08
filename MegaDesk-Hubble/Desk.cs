using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hubble
{
    public class Enum {
        public enum DesktopMaterial {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        };
    }
    class Desk{
        const int WMIN = 24;
        const int WMAX = 96;
        const int DMIN = 12;
        const int DMAX = 48;
        int width;
        int depth;
        int numberDrawers;
        string material;

        //Get constants
        public int getWMin() {
            return WMIN;
        }
        public int getWMax() {
            return WMAX;
        }
        public int getDMin() {
            return DMIN;
        }
        public int getDMax() {
            return DMAX;
        }

        //Get/Set width
        public int getWidth() {
            return width;
        }
        public void setWidth(int w) {
            this.width = w;
        }

        //Get/Set depth
        public int getDepth() {
            return depth;
        }
        public void setDepth(int d) {
            this.depth = d;
        }

        //Get/Set drawers
        public int getNumberDrawers() {
            return numberDrawers;
        }
        public void setNumberDrawers(int nd) {
            this.numberDrawers = nd;
        }

        //Get/Set material
        public string getMaterial() {
            return material;
        }
        public void setMaterial(string m) {
            this.material = m;
        }

    }


}
