using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph<string>();

            // check nodes with same names
            var nA = new SearchNode<string>("A", "A");
            var nB = new SearchNode<string>("B", "B");
            var nC = new SearchNode<string>("C", "C");
            var nD = new SearchNode<string>("D", "D");
            var nE = new SearchNode<string>("E", "E");
            var nF = new SearchNode<string>("F", "F");

            graph.AddEdge(new Edge<String>(nA, nB));
            graph.AddEdge(new Edge<String>(nA, nC));
            graph.AddEdge(new Edge<String>(nB, nC));
            graph.AddEdge(new Edge<String>(nB, nE));
            graph.AddEdge(new Edge<String>(nA, nD));
            graph.AddEdge(new Edge<String>(nD, nE));
            graph.AddEdge(new Edge<String>(nD, nF));

            graph.PrintGraph();

            foreach (var node in graph.GetAllNodes())
            {
                Console.Write(node.GetName() + ": ");
                foreach (var neighbor in node.GetNeighbors())
                    Console.Write(neighbor.GetName() + ", ");
                Console.WriteLine();
            }

            ArrayList result = SearchAlgorithms<string>.BreathFirstSearch(nA, nF);
            foreach (SearchNode<string> node in result)
            {
                Console.Write(node.GetName() + " => ");
            }

            Console.ReadLine();
        }
    }
}
