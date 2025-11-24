namespace ArtificialIntelligenceSearchTree {
    internal class MainTree {

        public MainTreeNode root;

        public void display() {
            // For the sake of displaying alphabetically, we will use inorder traversal.
            InorderTraversal(root);

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
        private void InorderTraversal(MainTreeNode node) {

            if (node != null) {
                // First, go to the leftmost node
                InorderTraversal(node.left);
                Console.WriteLine("Name of the node: {0}", node.name);
                node.subTree.display();
                // Then, go to the rightmost node
                InorderTraversal(node.right);
            }

        }

    }
}
