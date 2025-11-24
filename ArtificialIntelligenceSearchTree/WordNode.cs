namespace ArtificialIntelligenceSearchTree {
    internal class WordNode {
        public WordNode left;
        public WordNode right;
        public string word;
        public int frequency;

        public WordNode(string word) {
            this.word = word;
            this.frequency = 0;
        }


    }
}
