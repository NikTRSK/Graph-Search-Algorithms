using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Node<TNode>
    {
        private TNode mValue;
        private string mName;
        private HashSet<Node<TNode>> mNeighbors;

        public Node(TNode value, string name)
        {
            mValue = value;
            mName = name;
            mNeighbors = new HashSet<Node<TNode>>();
        }

        public TNode GetValue() => mValue;

        public void SetValue(TNode value) => mValue = value;

        public string GetName() => mName;

        public void SetName(string name)
        {
            mName = name;
        }

        public void AddNeighbor(Node<TNode> node)
        {
            if (node != null) mNeighbors.Add(node);
        }

        public HashSet<Node<TNode>> GetNeighbors() => mNeighbors;
    }
}
