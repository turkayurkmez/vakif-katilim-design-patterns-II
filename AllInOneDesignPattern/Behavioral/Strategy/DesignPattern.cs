using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   /*
    * Bir işlevin yerine getirdiği bir operasyonda kullanılan algoritmanın; gelecekte değişmesi gerekirse nasıl hareket edersiniz?
    */

    public interface ISortStrategy
    {
        void Sort();
    }

    public class BubbleStrategy : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Bubble sort algoritması");
        }
    }

    public class HeapStrategy : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Heap....");
        }
    }

    public class CustomCollection
    {
        public void Sort(ISortStrategy sortStrategy)
        {

            sortStrategy.Sort();
        }

    }
}
