using System;


namespace Day3
{
    public class Product
    {
       private int pcode;
       private string pname;
       private double price;
       private double dis;
        public Product(int pcode,string pname,double price)
        {
            this.pcode = pcode;
            this.pname = pname;
            this.price = price;
        }
        public void Discount()
        {
            if(price>5000)
            {
                dis = 5000 - (5000 * 0.10);
               
                Console.WriteLine("Discounted price = " + dis);
            }
            else
                Console.WriteLine("final price = " + price);
            
        }
    }
}
