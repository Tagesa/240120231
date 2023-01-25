using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 0; i < 100; i++)
            {
                a = Menu();
                if (a == 0) {
                    return;
                }
            }

            Console.ReadKey();
        }

        public static int Menu() {
            //Создание вершин БАЗОВЫЙ
            List<int> k1 = new List<int>() { 2, 3, 4 };
            Vertex a1 = new Vertex(1, k1);

            List<int> k2 = new List<int>() { 3, 4 };
            Vertex a2 = new Vertex(2, k2);

            List<int> k3 = new List<int>() { 4 };
            Vertex a3 = new Vertex(3, k3);

            List<int> k4 = new List<int>() { 1, 2 };
            Vertex a4 = new Vertex(4, k4);

            Graph Gr = new Graph();

            Gr.AddVertex(a1);
            Gr.AddVertex(a2);
            Gr.AddVertex(a3);
            Gr.AddVertex(a4);


            Console.WriteLine("Старт");
            Console.WriteLine("1. Вывести граф \n2. Добавить вершину \n3. Удалить вершину \n4. Добавить смежность \n5. Удалить смежность");

            int rez = Convert.ToInt32(Console.ReadLine());
            if (rez == 1)
            {
                foreach (var item in Gr.list)
                {
                    item.Printt();
                }
            }
            else if (rez == 2)
            {
                Console.WriteLine("Введите вершину");
                int Value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите смежноcть");
                int Value1 = Convert.ToInt32(Console.ReadLine());
                Gr.AddVertex(new Vertex(Value,new List<int> { Value1 }));
                Console.WriteLine("После добавления");
                foreach (var item in Gr.list)
                {
                    item.Printt();
                }
            }
            else if (rez == 3)
            {
                Console.WriteLine("Введите вершину");
                int Value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("После удаления вершины {0}", Value.ToString());
                var ver = Gr.list.Find(x => x.vertex == Value);
                Gr.DeliteVertex(ver);
                foreach (var item in Gr.list)
                {
                    item.Printt();
                }
            }
            else if (rez == 4)
            {
                Console.WriteLine("Введите вершину");
                int Value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите смежноcть");
                int Value1 = Convert.ToInt32(Console.ReadLine());
                var ver = Gr.list.Find(x => x.vertex == Value);
                Gr.AddConnection(ver, Value1);
                Console.WriteLine("После добавления ребра вершине {0}", Value.ToString());

                foreach (var item in Gr.list)
                {
                    item.Printt();
                }
            }
            else if (rez == 5)
            {
                Console.WriteLine("Введите вершину");
                int Value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите смежноcть");
                int Value1 = Convert.ToInt32(Console.ReadLine());
                var ver = Gr.list.Find(x => x.vertex == Value);

                Gr.DeleteConnection(ver, Value1);
                Console.WriteLine("После удаления ребра вершине {0}", Value.ToString());

                foreach (var item in Gr.list)
                {
                    item.Printt();
                }
            }
            else
            {
                return 0;
            }
            return 2;
        }
    }
}
