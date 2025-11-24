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
                        return;
                    }


                } else if (current.word.CompareTo(word)<0) {

                    if (current.right != null) {
                        current = current.right;
                    } else {
                        current.right = wordNodeToAdd;
                        return;
                    }

                } else {
                    current.frequency++;
                    return;
                }

            }

        }



    }
}
