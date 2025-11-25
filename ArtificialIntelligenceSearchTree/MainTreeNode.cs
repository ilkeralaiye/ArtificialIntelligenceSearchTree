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

        // Copy Constructor with extra name parameter
        public MainTreeNode(string name, MainTreeNode fromCopy) {

            this.left = fromCopy.left;
            this.right = fromCopy.right;
            this.subTree = fromCopy.subTree;
            this.name = name;

        }

        public string toString() {
            return ("A Main Tree Node, name: " +  this.name);
        }

    }
}
