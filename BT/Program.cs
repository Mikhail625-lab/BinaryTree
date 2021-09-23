using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BT
{
    // random rnd


    // random rnd 

    class BeTree2
    {

        // declare method(s)
        public void ShowTree()
        {
        }
        public void InsertInTree()
        { }
    }

    class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        // constructors 
        public Node() { Left = null;Right = null;Value = 0;     }
        public Node(Node l, Node r, int i){ Left = l; Right = r; Value = i; }
    }



    class Program
    {
         public static int GetRnd(int min, int max)
        {
            if (min == null) { min = 0; }
            if (max == null) { max = 1001; }


            Random rnd1 = new Random();
            Random rnds = new Random();

            Console.Write("\r|"); Thread.Sleep(rnds.Next(1, 10)); Console.Write("\r|");
            Console.Write("\r/"); Thread.Sleep(rnds.Next(1, 10)); Console.Write("\r/");
            Console.Write("\r-"); Thread.Sleep(rnds.Next(1, 10)); Console.Write("\r-");
            Console.Write("\r\\"); Thread.Sleep(rnds.Next(1, 10)); Console.Write("\r\\");
            return rnd1.Next(min, max);
        }

        public static List<int> TreeByLevels(Node node)
        {
            //off ya go!
            return null;
        }

        static void Main(string[] args)
        {
            int minRnd; int maxRnd;
            int qtyElements;
            Random rand = new Random();
            Node[] nods = new Node[200];

            // init var
            minRnd = 100000;
            maxRnd = 900001;
            qtyElements = 9;

            Console.WriteLine("start");
            for (int i = 0; i < qtyElements + 1; i++)
            {
                // nods[i] = new Node(GetRnd(minRnd, maxRnd));

            }

            for (int i = 0; i < qtyElements + 1; i++)
            { //Console.WriteLine("{0,5:N0} {1}", i, nods[i].Value.ToString());
               // Console.WriteLine("{0} {1}", i, nods[i].Value.ToString());
            }
            Console.ReadKey();

            new List<int>() { 1, 2, 3, 4, 5, 6 }; 
            List<Node> dtList = new List<Node>();
            new Node(null, null, 5);

           // TreeByLevels(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1));





        }  // *end of static void Main




 





    } // *end of  class Program
}
