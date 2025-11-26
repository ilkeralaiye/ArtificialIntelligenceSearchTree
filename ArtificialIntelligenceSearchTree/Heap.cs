namespace ArtificialIntelligenceSearchTree {
    internal class Heap {

        private MainTreeNode[] heapArray;
        public int capacity;
        private int length;
        private bool isMeanHeap;

        public Heap(int capacity, bool isMinHeap) {
            this.capacity = capacity;
            this.length = 0;
            this.isMeanHeap = isMeanHeap;
            heapArray = new MainTreeNode[capacity];
        }

        public bool isEmpty() {
            return this.length == 0;
        }

        public bool Insert(MainTreeNode node) {

            if (this.length == this.capacity) {
                return false;
            }

            heapArray[length] = node;
            if (isMeanHeap) {
                trickleUpMinHeap(length++);
            } else {
                trickleUpMaxHeap(length++);
            }
            return true;

        }

        public MainTreeNode getItemN(int index) {

            if (index < capacity) {

                return heapArray[index];

            }return null;

        }

        public void trickleUpMaxHeap(int index) {

            int parent = (index - 1) / 2;
            MainTreeNode bottom = heapArray[index];

            while (index > 0 && heapArray[parent].name.CompareTo(heapArray[index].name) < 0) {

                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;

            }
            heapArray[index] = bottom;

        }

        public void trickleUpMinHeap(int index) {

            int parent = (index - 1) / 2;
            MainTreeNode bottom = heapArray[index];

            while (index > 0 && heapArray[parent].name.CompareTo(heapArray[index].name) > 0) {

                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;

            }
            heapArray[index] = bottom;

        }

        public MainTreeNode remove() {
            MainTreeNode root = heapArray[0];
            heapArray[0] = heapArray[--length];
            if (isMeanHeap) {
                trickleDownMinHeap(0);
            } else {
                trickleDownMaxHeap(0);
            }

            
            return root;
        }

        public void trickleDownMaxHeap(int index) {

            int largerChild;
            MainTreeNode top = heapArray[index];

            while (index < length/2) {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild+1;

                if (rightChild < length && heapArray[leftChild].name.CompareTo(heapArray[rightChild].name) < 0) {
                    largerChild = rightChild;
                } else {
                    largerChild = leftChild;
                }

                if (top.name.CompareTo(heapArray[largerChild].name) <= 0) {
                    break;
                }

                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;

        }

        public void trickleDownMinHeap(int index) {

            int smallerChild;
            MainTreeNode top = heapArray[index];

            while (index < length / 2) {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;

                if (rightChild < length && heapArray[leftChild].name.CompareTo(heapArray[rightChild].name) > 0) {
                    smallerChild = rightChild;
                } else {
                    smallerChild = leftChild;
                }

                if (top.name.CompareTo(heapArray[smallerChild].name) <= 0) {
                    break;
                }

                heapArray[index] = heapArray[smallerChild];
                index = smallerChild;
            }
            heapArray[index] = top;

        }

    }
}
