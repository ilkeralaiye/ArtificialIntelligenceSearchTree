namespace ArtificialIntelligenceSearchTree {
    internal class MainTreeNode {

        public MainTreeNode left;
        public MainTreeNode right;

        public MainTree subTree;

        public string name;

        public MainTreeNode(string name) {
            subTree = new MainTree();
            this.name = name;
        }

    }
}
