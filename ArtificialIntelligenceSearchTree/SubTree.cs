namespace ArtificialIntelligenceSearchTree {
    internal class SubTree {

        public SubTreeNode root;
        public int maxDepth;

        public SubTree() {
            this.maxDepth = maxDepth;
        }

        public void display() {

            // For the sake of displaying alphabetically, we will use inorder traversal.
            InorderTraversal(root, -1);

        }

        public void Insert(SubTreeNode node) {

            if (root == null) {
                root = node;
                return;
            }

            SubTreeNode current = root;
            while (true) {

                // Add left
                if (current.name.CompareTo(node.name) > 0) {

                    if (current.left != null) {
                        current = current.left;
                    } else {
                        current.left = node;
                        return;
                    }

                } else if (current.name.CompareTo(node.name) < 0) {

                    if (current.right != null) {
                        current = current.right;
                    } else {
                        current.right = node;
                        return;
                    }
                }



            }

        }

        private void InorderTraversal(SubTreeNode node, int depth) {

            depth++;
            if (depth > maxDepth) {
                this.maxDepth = depth;
            }

            if (node != null) {

                // First, go to the leftmost node
                InorderTraversal(node.left, depth);
                // Print the current node's informations.
                Console.WriteLine("\tName of the subtree node: {0}", node.name); // Name
                Console.WriteLine("\t\tDescription: {0}", node.description); // Description
                Console.WriteLine("\t\tApplication Areas: {0}", node.applicationAreas); // Application Areas
                // Then, go to the rightmost node
                InorderTraversal(node.right, depth);
            }

        }

    }
}
