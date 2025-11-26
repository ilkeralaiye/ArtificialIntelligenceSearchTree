namespace ArtificialIntelligenceSearchTree {
    internal class WordNode {
        public WordNode left; // Left Child
        public WordNode right; // Right Child
        public string word;
        public int frequency; // frequency of word in descriptions
        
        // One parameter Constructor
        public WordNode(string word) {
            this.word = word;
            this.frequency = 0;
        }
    }
}
