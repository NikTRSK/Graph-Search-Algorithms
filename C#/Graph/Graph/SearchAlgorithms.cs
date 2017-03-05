using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class SearchAlgorithms<TNode>
    {
        /*
        * Returns a path from the starting to the end node
        * Returns null if can't find endNode
        * */
        public static ArrayList BreathFirstSearch(SearchNode<TNode> startNode, SearchNode<TNode> targetNode) {
            var queue = new Queue<SearchNode<TNode>>();
        
            queue.Enqueue(startNode);
        
            while(queue.Count != 0) {
                var currentNode = queue.Dequeue();
                if (!currentNode.IsVisited())
                {
                    currentNode.MarkVisited();
                    if (currentNode == targetNode)
                        return GetPath(currentNode);

                    foreach (SearchNode<TNode> neighbor in currentNode.GetNeighbors())
                    {
                        if (!neighbor.IsVisited())
                        {
                            neighbor.SetParent(currentNode);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
            return null;
        }

        /* HELPER FUNCTION */
        private static ArrayList GetPath(SearchNode<TNode> statingPoint)
        {
            var path = new ArrayList();
            SearchNode<TNode> currentNode = statingPoint;
            while (currentNode.ParentExists())
            {
                path.Add(currentNode);
                currentNode = currentNode.GetParent();
            }
            path.Add(currentNode); // Add starting node
            path.Reverse();
            return path;
        }
    }
}
