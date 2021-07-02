using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    public class Node
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ChangeTime { get; set; }

        public Node()
        {
            Name = string.Empty;
            Text = string.Empty;
            CreationTime = DateTime.Now;
            ChangeTime = DateTime.Now;
        }

        public Node(string name,string text)
        {
            Name = name;
            Text = text;
            CreationTime = DateTime.Now;
            ChangeTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nText: {Text}\nCreation Time: {CreationTime}\nChange Time: {ChangeTime}";
        }

        public override bool Equals(object obj)
        {
            return obj is Node node &&
                   Text == node.Text &&
                   Name == node.Name &&
                   CreationTime == node.CreationTime &&
                   ChangeTime == node.ChangeTime;
        }

        public override int GetHashCode()
        {
            int hashCode = -666272035;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + CreationTime.GetHashCode();
            hashCode = hashCode * -1521134295 + ChangeTime.GetHashCode();
            return hashCode;
        }
    }
}
