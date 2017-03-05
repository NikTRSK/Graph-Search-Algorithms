package graph.data;

import java.util.HashSet;
import java.util.Set;

public class Node<NodeType> {
    private NodeType mValue;
    private String mName;
    private Set<Node<NodeType>> mNeighbors;

    public Node(NodeType value, String name) {
        mValue = value;
        mName = name;

        mNeighbors = new HashSet<Node<NodeType>>();
    }

    public NodeType GetValue() {
        return mValue;
    }

    public void SetValue(NodeType value) {
       this.mValue = value;
    }

    public String GetName() {
        return mName;
    }

    public void SetName(String name) {
        this.mName = name;
    }

    public void AddNeighbor(Node<NodeType> node) {
        mNeighbors.add(node);
    }

    public Set<Node<NodeType>> GetNeighbors() {
        return mNeighbors;
    }
}
