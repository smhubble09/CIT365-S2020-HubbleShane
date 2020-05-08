using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hubble
{
    class DeskQuote
    {
        private int rushDays;
        private string customerName;
        private string quoteDate;
        private double price;
        private int materialPrice;
        private int shippingPrice;
        private int drawerPrice;
        private int extraSizePrice;

        //Get/Set Customer Name
        public string getCustName() {
            return customerName;
        }
        public void setCustName(string cn) {
            this.customerName = cn;
        }

        //Get/Set Rush Days
        public int getRushDays() {
            return rushDays;
        }
        public void setRushDays(int rd) {
            this.rushDays = rd;
        }

        //Get/Set Quote Date
        public string getQuoteDate() {
            return quoteDate;
        }
        public void setQuoteDate(string qd) {
            this.quoteDate = qd;
        }

        //Get/Set Price
        public double getPrice() {
            return price;
        }
        public void setPrice(double pr) {
            this.price = pr;
        }

        //-------------------------------------------------------
        Desk de = new Desk();

        //Calculate Extra Size Cost
        public void SetExtraSizeCost(int sqi) {
            this.extraSizePrice = sqi;
        }

        //Calculate Drawer Cost
        public int DrawerCost(int drawers) {
            drawerPrice = drawers * 50;
            return drawerPrice;
        }

        //Calculate Material Cost
        public int MaterialCost(string mc) {
            switch (mc) {
                case "Oak"://Oak
                    materialPrice = 200;
                    return 200;
                case "Laminate"://Laminate
                    materialPrice = 100;
                    return 100;
                case "Pine"://Pine
                    materialPrice = 50;
                    return 50;
                case "Rosewood"://Rosewood
                    materialPrice = 300;
                    return 300;
                case "Veneer"://Veneer
                    materialPrice = 125;
                    return 125;
                default:
                    return 0;
            }
        }

        //Calculate Rush Order
        public int ShippingCost(int sc) {
            switch (rushDays) {
                case 0://3 Day
                    if (sc < 1000) {
                        shippingPrice = 60;
                        return 60;
                    }
                    else if (sc > 2000) {
                        shippingPrice = 80;
                        return 80;
                    }
                    else {
                        shippingPrice = 70;
                        return 70;
                    }
                case 1://5 Day
                    if (sc < 1000) {
                        shippingPrice = 40;
                        return 40;
                    }
                        
                    else if (sc > 2000) {
                        shippingPrice = 60;
                        return 60;
                    } 
                    else {
                        shippingPrice = 50;
                        return 50;
                    }
                case 2://7 Day
                    if (sc < 1000) {
                        shippingPrice = 30;
                        return 30;
                    }
                    else if (sc > 2000) {
                        shippingPrice = 40;
                        return 40;
                    }
                    else {
                        shippingPrice = 35;
                        return 35;
                    }
                case 3://Normal
                    shippingPrice = 0;
                    return 0;
                default:
                    return 0;
            }
        }

        //Calculate Total Cost
        public void TotalCost() {
            double total = shippingPrice + materialPrice + drawerPrice + extraSizePrice + 200;
            setPrice(total);
            //AddQuote.TotalCostLabel.Text = Convert.ToDecimal(total).ToString("#,##0.00");
        }



    }
}
