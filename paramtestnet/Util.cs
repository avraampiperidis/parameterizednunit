using System;

namespace paramtestnet.Util
{
    public class Util
    {
        public static double calculate(double price,int quantity,double discount,int categoryType) 
        {
            double totalPrice = price * quantity;
            double totalPriceWithDiscount = System.Math.Round(totalPrice - (totalPrice * discount/100),2);
            return totalPriceWithDiscount;
        }
    }
}