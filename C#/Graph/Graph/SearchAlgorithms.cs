using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public static ArrayList DepthFirstSearch(SearchNode<TNode> startNode, SearchNode<TNode> targetNode, bool recursive)
        {
            return recursive ? DepthFirstSearchRecursive(startNode, targetNode) : DepthFirstSearchIterative(startNode, targetNode);
        }

        private static ArrayList DepthFirstSearchIterative(SearchNode<TNode> startNode, SearchNode<TNode> targetNode)
        {
            Stack<SearchNode<TNode>> stack = new Stack<SearchNode<TNode>>();
            stack.Push(startNode);

            while (stack.Count != 0)
            {
                SearchNode<TNode> currentNode = stack.Pop();
                if (!currentNode.IsVisited())
                {
                    currentNode.MarkVisited();
                    if (currentNode == targetNode)
                        return GetPath(targetNode);
                    foreach (SearchNode<TNode> neighbor in currentNode.GetNeighbors())
                    {
                        if (!neighbor.IsVisited())
                        {
                            neighbor.SetParent(currentNode);
                            if (neighbor == targetNode)
                                return GetPath(targetNode);
                            stack.Push(neighbor);
                        }
                    }
                }
            }
            return null;
        }

//        private static ArrayList DepthFirstSearchRecursive(SearchNode<TNode> startNode, SearchNode<TNode> targetNode)
//        {
//            startNode.MarkVisited();
//            Console.WriteLine("EXPLORING: " + startNode.GetName());
//            if (startNode == targetNode)
//                return GetPath(targetNode);
//            foreach (SearchNode<TNode> neighbor in startNode.GetNeighbors())
//            {
//                if (!neighbor.IsVisited())
//                {
//                    neighbor.SetParent(startNode);
//                    if (neighbor == targetNode)
//                        return GetPath(targetNode);
//                    DepthFirstSearchRecursive(neighbor, targetNode);
//                }
//            }
//            return null;
//        }

        public static ArrayList AStar()
        {
            return null;
        }

        public static ArrayList DStar()
        {
            return null;
        }

        public static ArrayList RapidlyExploringRandomTree()
        {
            return null;
        }

        public static ArrayList ProbabilisticRoadmap()
        {
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
