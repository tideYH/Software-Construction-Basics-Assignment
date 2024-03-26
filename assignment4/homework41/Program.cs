using System;

namespace GenericApplication
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    // 泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
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
            // 整型List
            GenericList<int> intList = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intList.Add(x);
            }

            // 使用ForEach打印所有元素
            intList.ForEach(x => Console.WriteLine(x));

            // 求最大值
            int max = int.MinValue;
            intList.ForEach(x => {
                if (x > max) max = x;
            });
            Console.WriteLine($"最大值: {max}");

            // 求最小值
            int min = int.MaxValue;
            intList.ForEach(x => {
                if (x < min) min = x;
            });
            Console.WriteLine($"最小值: {min}");

            // 求和
            int sum = 0;
            intList.ForEach(x => sum += x);
            Console.WriteLine($"总和: {sum}");

            // 字符串型List
            GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }

            // 使用ForEach打印所有字符串元素
            strList.ForEach(s => Console.WriteLine(s));

            // 可以根据需要对字符串进行其他操作，比如打印长度等
        }
    }
}
