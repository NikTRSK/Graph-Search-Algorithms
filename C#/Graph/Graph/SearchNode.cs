namespace Graph
{
    public class SearchNode<TNode> : Node<TNode>
    {
        private SearchNode<TNode> mParent;
        private bool mVisited;

        public SearchNode(TNode value, string name) : base(value, name)
        {
            mVisited = false;
            mParent = null;
        }

        public SearchNode<TNode> GetParent() => mParent;

        public void SetParent(SearchNode<TNode> parent) => mParent = parent;

        public bool IsVisited() => mVisited;

        public void MarkVisited() => mVisited = true;

        public void UnmarkVisited() => mVisited = false;

        public bool ParentExists() => mParent != null;
    }
}
