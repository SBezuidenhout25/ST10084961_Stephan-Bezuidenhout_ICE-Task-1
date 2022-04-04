using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjExcersise11
{
    class cart
    {
        private int minOrder;
        private double totalVAT = 0;
        private double total = 0;
        private string[] itemNames;
        private double[] itemPrices;
        private double[] itemVat;
        public cart(int MIN_ORDER)
        {
            minOrder = MIN_ORDER;
            itemNames = new string[minOrder];
            itemPrices = new double[minOrder];
            itemVat = new double[minOrder];
        }
    
        
        public void storeInCart(string itemName, double itemPrice, int currentItem, double vat)
        {
            itemNames[currentItem] = itemName;
            itemPrices[currentItem] = itemPrice;
            itemVat[currentItem] = vat;
            totalVAT += vat;
            total += itemPrice;
        }
        public override string ToString()
        {
            string strOutput = "\n---------------------------------------------\n";

            for (int x = 0; x < minOrder; x++)
            {
                strOutput += itemNames[x] + "       R" + itemPrices[x] + "\n";
            }
            strOutput += "-------------------------------------------\n";
            strOutput += "Total R" + total + "\n+ VAT R" + Math.Round(totalVAT,2) + "\n";
            strOutput += "-------------------------------------------\n";
            strOutput += "Grand Total: R" + Math.Round((total + totalVAT),2);
            strOutput += "\n-------------------------------------------";

            return strOutput;
        }
    }
}
