using Day3;
using System.Collections;

namespace Day3
{ 
    public class Testing
    {
        static void Main(string[] args)
        {
            Product p = new Product(1025,"headphones",6000);
            p.Discount();
            
            Console.WriteLine("---------------------");
            Console.WriteLine("2D array of 3 by 4");
            int[,] details = new int[3, 4]
        {
            {1,2,3,4 },
            {5,6,7,8 },
            {9,10,11,12 }
        };
            for (int i = 0; i < 3; i++)
            {
                for (int j=0;j<4;j++)
                {
                    Console.Write(details[i,j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] data = new int[6, 3]
                {
                    {1,2,3 },
                    {4,5,6 },
                    {7,8,9 },
                    {10,11,12 },
                    {13,14,15 },
                    {16,17,18 }
                };
            for(int i=0;i<data.GetLength(0);i++)
            {
                for(int j=0;j<data.GetLength(1);j++)
                {
                    Console.Write(data[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("ArrayLIst");
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("String");
            al.Add("generic");
            al.Add(21);
            al.Add(32);
            al.Add(65);
            al.Add(101);
            al.Add(321);
            al.Add(654);
            Console.WriteLine("remove , remove at , remove range : ");
            al.Remove(1);
            al.RemoveAt(3);
            al.RemoveRange(2, 2);
            Console.WriteLine("count = "+ al.Count);
            al.IndexOf("index of 101 = " + 101);
            Console.WriteLine("insert : ");
            al.Insert(2,66666);
            foreach(object x in al)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("stack");
            Stack stk = new Stack();
            stk.Push(1);
            stk.Push(2);
            stk.Push(13);
            stk.Push(14);
            stk.Push(15);
            stk.Push(17);
            stk.Push(18);
            stk.Push(19);
            stk.Pop();
            foreach(object x in stk)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine(  "Queue");
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Dequeue();
            foreach(object x in q)
            {
                Console.WriteLine(x);
            }




            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
           

        }
    }
}
