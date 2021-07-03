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

            public void OrderByNameDecreasing() => Nodes = Nodes.OrderBy(x => x.Name).ToList();
            
            public void OrderByNameIncreasing()
            {
                OrderByNameDecreasing();
                Nodes.Reverse();
            }

            public void OrderByCreationTimeDecreasing() => Nodes = Nodes.OrderBy(x => x.CreationTime).ToList();
            
            public void OrderByCreationTimeIncreasing()
            {
                OrderByCreationTimeDecreasing();
                Nodes.Reverse();
            }

            public void OrderByChangeTimeDecreasing() => Nodes = Nodes.OrderBy(x => x.ChangeTime).ToList();
            
            public void OrderByChangeTimeIncreasing()
            {
                OrderByChangeTimeDecreasing();
                Nodes.Reverse();
            }

            public List<Node> SearchByName(string name) => Nodes.Where(x => x.Name.Contains(name)).ToList();

            public List<Node> SearchByCreationTime(DateTime creationTime) => Nodes.Where(x => x.CreationTime.ToString().Contains(creationTime.ToString())).ToList();

            public List<Node> SearchByChangeTime(DateTime changeTime) => Nodes.Where(x => x.ChangeTime.ToString().Contains(changeTime.ToString())).ToList();

        }
    }
