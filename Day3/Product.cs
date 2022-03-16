using System;


namespace Day3
{
    public class Product
    {
       private int pcode;
       private string pname;
       private double price;
       private double dis;
       private double disprice;
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
                dis =(price * 0.10);
                disprice = price - dis;
                Console.WriteLine("Discounted price = " + disprice);
            }
            else
                Console.WriteLine("final price = " + price);
            
        }
    }
}
