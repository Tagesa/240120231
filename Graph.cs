using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    class Vertex
    {
        public int vertex;
        public List<int> ConnectionList;
        public Vertex(int Vertex, List<int> ConnectionList) {
            this.vertex = Vertex;
            this.ConnectionList = ConnectionList;
        }

        public void Printt() {
            Console.Write("Вершина: {0}, смежные вершины: [ ", vertex.ToString());
            foreach (var elem in ConnectionList)
            {
                Console.Write(elem + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        
    }
    class Graph
    {
        public List<Vertex> list = new List<Vertex>();
        public void AddVertex(Vertex edit)
        {
            list.Add(edit);
        }

        public void DeliteVertex(Vertex edit)
        {
            list.Remove(edit);
        }

        public void AddConnection(Vertex edit, int Connection) {
            var iSFind = list.Find(x => x.vertex == edit.vertex);
            if (iSFind != null) {
                edit.ConnectionList.Add(Connection);                
            }
            else {
                Console.WriteLine("Нет смежности");
            }            
        }

        public void DeleteConnection(Vertex edit, int Connection)
        {
            var iSFind = list.Find(x => x.vertex == edit.vertex);
            if (iSFind != null)
            {
                var Number = edit.ConnectionList.Find(x => x == Connection);
                if (Number != null)
                {
                    edit.ConnectionList.Remove(Connection);
                }
                else
                {
                    Console.WriteLine("Данная смежность нет");
                }
            }
            else
            {
                Console.WriteLine("Нет смежности");
            }
        }
    }
}
