using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace LogicLib
    {
        [Serializable]
        public class NodeManager
        {
            public List<Node> Nodes { get; set; } = new List<Node>();
            public string Path { get; set; }

            public NodeManager()
            {

            }

            public NodeManager(List<Node> nodes, string path)
            {
                Nodes = nodes;
                Path = path;
            }

            public void OrderByNameDecreasing()
            {
                Nodes = Nodes.OrderBy(x => x.Name).ToList();
            }

            public void OrderByNameIncreasing()
            {
                OrderByNameDecreasing();

                Nodes.Reverse();
            }

        }
    }
