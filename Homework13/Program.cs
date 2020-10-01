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

            Queue<string> linkedList = new Queue<string>();
            // добавление элементов
            linkedList.AddToEnd("Tom");
            linkedList.AddToEnd("Alice");
            linkedList.AddToEnd("Bob");
            linkedList.AddToEnd("Sam");

            // выводим элементы
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // удаляем элемент
            linkedList.Delete("Alice");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Delete \"Alice\"");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // проверяем наличие элемента
            bool isPresent = linkedList.Contains("Sam");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("проверяем наличие элемента \"Sam\"");
            Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");

            // проверяем наличие элемента
            isPresent = linkedList.Contains("Bill!!!!");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("проверяем наличие элемента \"Bill!!!!\"");
            Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");

            // добавляем элемент в начало            
            linkedList.AddToStart("Bill");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в начало  \"Bill\"");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // добавляем элемент в конец            
            linkedList.AddToEnd("Bill!!!!");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в конец  \"Bill!!!!\"");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // добавляем элемент в индекс 3            
            linkedList.AddByIndex("Bill??????",3);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("добавляем элемент в индекс 3  \"Bill??????\"");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            // получаем 3 элемент
            //isPresent = linkedList.Contains("Bill!!!!");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("получаем 3 элемент");
            Console.WriteLine(linkedList[3].Data);



            Console.ReadKey();
        }
    }
}
