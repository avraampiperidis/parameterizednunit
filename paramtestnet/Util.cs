
namespace paramtestnet.Util
{
    public class Util
    {
        public static double calculateCategory(double price,int quantity,double discount,int category) 
        {   
            return calculate(price,quantity,discount) + (category == 1 ? 5 : 6.5);
        }

        public static double calculate(double price,int quantity,double discount) 
        {
            return calculateDiscount(discount,calculatePrice(price,quantity));
        }

        public static double calculatePrice(double price,double quantity) {
            return price * quantity;
        }

        public static double calculateDiscount(double discount,double totalPrice) {
            return System.Math.Round(totalPrice - (totalPrice * discount/100),2);
        }
    }
}