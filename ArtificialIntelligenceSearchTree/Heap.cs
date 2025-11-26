namespace ArtificialIntelligenceSearchTree {
    internal class Heap {

        public int capacity;
        private int size;
        private MainTreeNode[] items;

        public Heap(int capacity) {

            this.capacity = capacity;
            this.size = 0;
            items = new MainTreeNode[capacity];
        }

        public MainTreeNode getItem(int index) {
            return items[index];
        }

        private int getLeftChildIndex(int index) {
            return 2 * index + 1;
        }

        private int getRightChildIndex(int index) {
            return 2 * index + 2;
        }

        private int getParentIndex(int index) {
            return (index - 1) / 2;
        }

        private bool hasLeftChild(int index) {
            return getLeftChildIndex(index) < size;
        }

        private bool hasRightChild(int index) {
            return getRightChildIndex(index) < size;
        }

        private bool hasParent(int index) {
            return getParentIndex(index) >= 0;
        }

        private MainTreeNode leftChild(int index) { 
            return items[getLeftChildIndex(index)];
        }
        private MainTreeNode rightChild(int index) { 
            return items[getRightChildIndex(index)];
        }
        private MainTreeNode parent(int index) { 
            return items[getParentIndex(index)];
        }

        private void swap(int i, int j) {
            MainTreeNode temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        public MainTreeNode Peek() {
            if (size == 0) { return null; }
            return items[0];
        }

        public MainTreeNode Remove() {
            if (size == 0) { return null; }
            MainTreeNode item = items[0];
            items[0] = items[size - 1];

            trickleDown();

            return item;
        }

        public void trickleDown() {

            int index = 0;
            int smallerChildIndex;

            while (hasLeftChild(index)) {

                if (hasRightChild(index)) {

                    if (rightChild(index).name.CompareTo(leftChild(index).name) < 0) {
                        smallerChildIndex = getRightChildIndex(index);
                    } else {
                        smallerChildIndex = getLeftChildIndex(index);
                    }

                } else {
                    smallerChildIndex = getLeftChildIndex(index);
                }

                if (items[index].name.CompareTo(items[smallerChildIndex].name) < 0) {
                    break;
                } else {
                    swap(index, smallerChildIndex);
                }
                index = smallerChildIndex;


            }



        }

        public void Insert(MainTreeNode item) {

            if (size != capacity) {
                items[size++] = item;
                trickleUp();
            }

        }

        public void trickleUp() {

            int index = size - 1;

            while (hasParent(index) && parent(index).name.CompareTo(items[index].name) < 0) {
                swap(getParentIndex(index), index);
                index = getParentIndex(index);
            }


        }

    }
}
