package graph.data;

public class WeightedEdge<NodeType> extends Edge {
    private Integer mWeight;

    public WeightedEdge(Node<NodeType> startNode, Node<NodeType> endNode, Integer weight) {
        super(startNode, endNode);
        mWeight = weight;
    }

    public Integer GetWeight() {
        return mWeight;
    }

    public void SetWeight(Integer weight) {
        this.mWeight = weight;
    }
}
