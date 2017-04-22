using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();
            MyList.AddAtHead(3);
            MyList.AddAtHead(20);
            MyList.AddAtHead(1);
            MyList.AddAtHead(0);
            MyList.AddAtTail(4);
            MyList.AddAtTail(5);
            MyList.DeleteNode(20);
            MyList.printAllNodes();
            Console.ReadKey();
        }
       
       
      

      
    }
}
