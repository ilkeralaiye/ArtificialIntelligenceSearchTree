namespace ArtificialIntelligenceSearchTree {
    internal class MainTree {

        public MainTreeNode root;
        public int maxDepth;
        public SubTree subMaxDepth;

        public MainTree() {
            maxDepth = 0;
        }

        public void display() {
            // For the sake of displaying alphabetically, we will use inorder traversal.
            InorderTraversal(root, 0);

        }

        public int getMaxDepth() {
            return this.maxDepth;
        }

        public void Insert(MainTreeNode node) {

            if (root == null) {
                root = node;
                return;
            }

            MainTreeNode current = root;
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

        // Display all information in alphabetic order with subfield informations.
        private void InorderTraversal(MainTreeNode node, int depth) {

            if (node != null) {
                SubTree subTree = node.subTree;
                
                // First, go to the leftmost node
                InorderTraversal(node.left, depth);
                Console.WriteLine("Name of the node: {0}", node.name);
                subTree.display();
                // Then, go to the rightmost node
                InorderTraversal(node.right, depth);

                if (subTree.maxDepth > maxDepth) {
                    maxDepth = subTree.maxDepth;
                    subMaxDepth = subTree;
                }

            }

        }

    }
}
