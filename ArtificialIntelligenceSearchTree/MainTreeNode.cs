namespace ArtificialIntelligenceSearchTree {
    internal class MainTreeNode {

        public MainTreeNode left;
        public MainTreeNode right;

        public SubTree subTree;

        public string name;

        public MainTreeNode(string name) {
            subTree = new SubTree();
            this.name = name;
        }

        public MainTreeNode(string name, SubTree subTree) {
            this.subTree = subTree;
            this.name = name;
        }




    }
}
