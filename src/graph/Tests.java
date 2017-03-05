package graph;

import graph.data.Edge;
import graph.data.Graph;
import graph.data.Node;

public class Tests {

    public static void main(String[] args) {
        Graph<String> graph = new Graph<String>();

        // check nodes with same names
        Node<String> nA = new Node<String>("A", "A");
        Node<String> nB = new Node<String>("B", "B");
        Node<String> nC = new Node<String>("C", "C");
        Node<String> nD = new Node<String>("D", "D");
        Node<String> nE = new Node<String>("E", "E");
        Node<String> nF = new Node<String>("F", "F");

        graph.AddEdge(new Edge<String>(nA, nB));
        graph.AddEdge(new Edge<String>(nA, nC));
        graph.AddEdge(new Edge<String>(nB, nC));
        graph.AddEdge(new Edge<String>(nB, nE));
        graph.AddEdge(new Edge<String>(nA, nD));
        graph.AddEdge(new Edge<String>(nD, nE));
        graph.AddEdge(new Edge<String>(nD, nF));

        graph.PrintGraph();

        System.out.println("NEIGHBORS");
        for (Node<?> node : graph.GetAllNodes()) {
            System.out.print(node.GetName() + ": ");
            for (Node<?> neighbor : node.GetNeighbors()) {
                System.out.print(neighbor.GetName() + ", ");
            }
            System.out.println();
        }
    }
}
