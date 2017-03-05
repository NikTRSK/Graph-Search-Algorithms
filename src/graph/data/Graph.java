package graph.data;

import java.util.HashSet;
import java.util.Set;

/* TODO: Remove Edge/Node */

public class Graph<NodeType> {

    private Set<Node<NodeType>> mNodes;
    private Set<Edge<NodeType>> mEdges;

    public Graph() {
        mNodes = new HashSet<>();
        mEdges = new HashSet<>();
    }

    /*
    * Add an edge with a start and end node.
    * */
    public void AddEdge(Node startNode, Node endNode) {
        AddNode(startNode);
        AddNode(endNode);
        AddEdge(new Edge<NodeType>(startNode, endNode));
    }

    public void AddEdge(Edge e) {
        mNodes.add(e.GetStartNode());
        mNodes.add(e.GetEndNode());
        mEdges.add(e);
    }

    /*
    * Returns a Set of all the Edges in the Graph
    * */
    public Set<Edge<NodeType>> GetAllEdges() {
        return mEdges;
    }

    /*
    * Returns a Set of all the Nodes in the Graph
    * */
    public Set<Node<NodeType>> GetAllNodes() {
        return mNodes;
    }

    /*
    * Returns an edge cantaining the node.
    * Returns null if edge doesn't exist
    * */
    public Edge<NodeType> GetEdge(Node<NodeType> node) {
      for (Edge<NodeType> edge : mEdges) {
        if (edge.Contains(node))
          return edge;
      }
      return null;
    }

    /*
    * Adds a Node to the Graph.
    * Returns true if the node didn't previously exist
    * */
    public Boolean AddNode(Node node) {
        if (node != null) {
            return mNodes.add(node);
        }
        return false;
    }

    /*
     * Reinitializes the graph to be empty, removing all nodes and arcs
     * and freeing any heap storage used by their corresponding internal structures.
     */
    public void Clear() {
        mNodes.clear();;
        mEdges.clear();
    }

    /*
     * Removes all arcs from the graph, freeing the heap storage used by their
     * corresponding internal structures. The graph's nodes remain intact.
     */

    public void PrintGraph() {
      StringBuilder sb = new StringBuilder();

      for(Node<NodeType> node : mNodes)
          sb.append(node.GetName() + ", ");
      // Remove the last comma
      sb.delete(sb.length()-2, sb.length());
      System.out.println("NODE LIST:");
      System.out.println(sb.toString());

      sb = new StringBuilder();

      for (Edge<NodeType> edge : mEdges)
        sb.append(edge.GetStartNode().GetName() + " -> "
                        + edge.GetEndNode().GetName() + ", ");
      // Remove the last comma
      sb.delete(sb.length()-2, sb.length());
      System.out.println("\nEDGE LIST:");
      System.out.println(sb.toString());
    }
}
