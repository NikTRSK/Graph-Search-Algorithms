using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Edge<TNode>
    {
        private Node<TNode> mStartNode;
        private Node<TNode> mEndNode;

        public Edge(Node<TNode> startNode, Node<TNode> endNode)
        {
            mStartNode = startNode;
            mEndNode = endNode;

            mStartNode.AddNeighbor(mEndNode);
            mEndNode.AddNeighbor(mStartNode);
        }

        public Node<TNode> GetStartNode() => mStartNode;

        public Node<TNode> GetEndNode() => mEndNode;

        public bool Contains(Node<TNode> node) => (node == mStartNode || node == mEndNode);

        public string PrintEdge() => (@mStartNode.GetName() + " => " + @mEndNode.GetName());
    }
}
