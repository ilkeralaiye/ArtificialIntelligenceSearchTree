using System.Xml.Linq;

namespace ArtificialIntelligenceSearchTree {
    internal class WordTree {

        public WordNode root;


        // Insertion
        public void Insert(string word) {
            WordNode wordNodeToAdd = new WordNode(word);

            if (root == null) {
                this.root = wordNodeToAdd;
                return;
            }

            WordNode current = root;
            while (true) {

                if (current.word.CompareTo(word)>0) {

                    if (current.left != null) {
                        current = current.left;
                    } else {
                        current.left = wordNodeToAdd;
                        current.left.frequency++;
                        return;
                    }


                } else if (current.word.CompareTo(word)<0) {

                    if (current.right != null) {
                        current = current.right;
                    } else {
                        current.right = wordNodeToAdd;
                        current.right.frequency++;
                        return;
                    }

                } else {
                    current.frequency++;
                    return;
                }

            }

        }

        public void display() {

            if (root == null) {
                Console.WriteLine("This WordTree is null. Please insert some words and try again.");
                return;
            }

            printInorderTraversal(root);


        }

        private void printInorderTraversal(WordNode node) {

            if (node != null) {
                printInorderTraversal(node.left);
                Console.WriteLine("Current Word: {0}, frequency {1}", node.word, node.frequency);
                printInorderTraversal(node.right);
            }

        }



    }
}
