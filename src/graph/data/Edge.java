package graph.data;

public class Edge<NodeType>
{
    private Node<NodeType> mStartNode;
    private Node<NodeType> mEndNode;

    public Edge(Node<NodeType> startNode, Node<NodeType> endNode) {
        mStartNode = startNode;
        mEndNode = endNode;

        mStartNode.AddNeighbor(mEndNode);
        mEndNode.AddNeighbor(mStartNode);
    }

    public Node<NodeType> GetStartNode() {
        return mStartNode;
    }

    public Node<NodeType> GetEndNode() {
        return mEndNode;
    }

    public Boolean Contains(Node<NodeType> node) {
        return (node == mStartNode || node == mEndNode);
    }
}
