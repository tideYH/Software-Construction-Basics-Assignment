using System;

namespace GenericApplication
{
    //链表节点
    public class Node<T> { 
        public Node<T> Next {  get; set; }
        public T Data { get; set; }

        public Node(T t)//定义所有数据类型都可以
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>//自定义泛型
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get=> head;
        }

        public void Add(T t)
        {
            Node<T> n=new Node<T>(t);
            if (tail == null)
            {
                head = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (Node<T> node = head; node != null; node = node.Next)
            {
                action(node.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int>intList = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intList.Add(x);
            }

            intList.ForEach(x => Console.WriteLine(x));

            int max = int.MinValue;
            intList.ForEach(x =>
            {
                if (x > max) max = x;
            });
            Console.WriteLine(max);

            int min = int.MaxValue;
            intList.ForEach(x =>
            {
                if (x < min) min = x;
            });
            Console.WriteLine(min);

            int sum = 0;
            intList.ForEach(x => sum += x);
            Console.WriteLine(sum);
            //使用委托先制作方法的抽象模板，然后使用lamdba表达式来灵活使用委托函数。
        }
    }
}


