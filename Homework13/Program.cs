using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.ReadKey();
        }
    }


    public class QueueItem<T>
    {
        public T Data { get; set; }
        public QueueItem<T> Next { get; set; }

        public QueueItem(T data)
        {
            Data = data;
        }
    }

    public class Queue<T> : IEnumerable<T>  // односвязный список
    {
        QueueItem<T> head; // головной/первый элемент
        QueueItem<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        public IEnumerator<T> GetEnumerator()
        {
            QueueItem<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        public void AddItem(T data)
        {
            QueueItem<T> queueItem = new QueueItem<T>(data);

            if (head == null)
            {
                head = queueItem;
            }  
            else
            {
                tail.Next = queueItem;
            }

            tail = queueItem;
            count++;
        }

    }
}
