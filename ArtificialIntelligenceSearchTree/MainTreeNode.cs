namespace ArtificialIntelligenceSearchTree {
    internal class MainTreeNode {

        public MainTreeNode left;
        public MainTreeNode right;

        public Tree subTree;

        public string name;

        public MainTreeNode(string name) {
            subTree = new Tree();
            this.name = name;
        }

    }
}
