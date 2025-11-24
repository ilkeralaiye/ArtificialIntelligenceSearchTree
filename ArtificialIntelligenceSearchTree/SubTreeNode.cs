namespace ArtificialIntelligenceSearchTree {
    internal class SubTreeNode {

        public SubTreeNode left;
        public SubTreeNode right;

        public string name;

        public string description;
        public string applicationAreas;

        public SubTreeNode(string name, string description, string applicationAreas) {
            this.name = name;
            this.description = description;
            this.applicationAreas = applicationAreas;
        }

    }
}
