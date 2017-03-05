using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph<TNode>
    {
        private HashSet<Node<TNode>> mNodes;
        private HashSet<Edge<TNode>> mEdges;

        public Graph()
        {
            mNodes = new HashSet<Node<TNode>>();
            mEdges = new HashSet<Edge<TNode>>();
        }

        /*
        * Add an edge with a start and end node.
        * */
        public void AddEdge(Node<TNode> startNode, Node<TNode> endNode)
        {
            AddNode(startNode);
            AddNode(endNode);
            AddEdge(new Edge<TNode>(startNode, endNode));
        }

        public void AddEdge(Edge<TNode> e)
        {
            mNodes.Add(e.GetStartNode());
            mNodes.Add(e.GetEndNode());
            mEdges.Add(e);
        }

        /*
        * Returns a Set of all the Edges in the Graph
        * */
        public HashSet<Edge<TNode>> GetAllEdges()
        {
            return mEdges;
        }

        /*
        * Returns a Set of all the Nodes in the Graph
        * */
        public HashSet<Node<TNode>> GetAllNodes()
        {
            return mNodes;
        }

        /*
        * Returns an edge cantaining the node.
        * Returns null if edge doesn't exist
        * */
        public Edge<TNode> GetEdge(Node<TNode> node)
        {
            return mEdges.FirstOrDefault(edge => edge.Contains(node));
        }

        /*
        * Adds a Node to the Graph.
        * Returns true if the node didn't previously exist
        * */
        public bool AddNode(Node<TNode> node)
        {
            if (node != null)
            {
                return mNodes.Add(node);
            }
            return false;
        }

        /*
         * Reinitializes the graph to be empty, removing all nodes and arcs
         * and freeing any heap storage used by their corresponding internal structures.
         */
        public void Clear()
        {
            mNodes.Clear();
            mEdges.Clear();
        }

        /*
         * Removes all arcs from the graph, freeing the heap storage used by their
         * corresponding internal structures. The graph's nodes remain intact.
         */

        public void PrintGraph()
        {
            Console.WriteLine("NODE LIST:");
            Console.WriteLine(string.Join(", ", mNodes.Select(node => node.GetName())));

            Console.WriteLine("\nEDGE LIST:");
            Console.WriteLine(string.Join(", ", mEdges.Select(edge => edge.PrintEdge())));
        }
    }
}
