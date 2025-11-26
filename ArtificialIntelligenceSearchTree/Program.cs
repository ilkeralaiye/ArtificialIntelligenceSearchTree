using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Linq;

namespace ArtificialIntelligenceSearchTree {
    internal class Program {
        static void Main(string[] args) {

            // First Part

            // Create MainTree and add Elements to itself.
            MainTree newMainTree = new MainTree();
            AddElementsFromJson(newMainTree, "data.json");

            newMainTree.display(); // Display MainTree

            printMaxDepth(newMainTree);

            WordTree newWordTree = new WordTree();
            printWordTree(newMainTree, newWordTree);

            // Second Part: HASHTABLE

            Hashtable hashtable = createHashTable(newMainTree);
            printHashTable(hashtable);
            updateHashTable(newMainTree, hashtable);
            printHashTable(hashtable);

            // Third Part: HEAP

            Heap heap = new Heap(4);
            newMainTree.addToHeap(heap);

            Console.WriteLine("\n");
            printN_HeapElement(heap, 5);

        }


        public static void printN_HeapElement(Heap heap, int n) {

            if (n>heap.capacity) {
                Console.WriteLine("\n\n given n:({0}) is bigger than heap's capacity. Printing {1} element of heap.", n, heap.capacity);
                n = heap.capacity;
            }

            for (int i=0;i<n;i++) {

                Console.WriteLine("{0}: {1}", i+1, heap.getItem(i).toString());

            }

        }

        public static void updateHashTable(MainTree newMainTree, Hashtable hashtable) {

            Console.Write("\nINPUT: Please enter a field name to find: ");
            string nameToFind = Console.ReadLine();
            Console.Write("\nINPUT: Please enter a field name for update: ");
            string nameToUpdate = Console.ReadLine();

            if (hashtable.ContainsKey(nameToFind)) {

                MainTreeNode newNode = new MainTreeNode(nameToUpdate, (MainTreeNode) hashtable[nameToFind]);
                hashtable.Remove(nameToFind);
                hashtable.Add(nameToUpdate, newNode);

            }


        }

        public static void printHashTable(Hashtable hashtable) {

            Console.WriteLine("\nPrinting hashtable key, value pairs\n");

            foreach (DictionaryEntry e in hashtable) {
                string key = (string) e.Key;
                MainTreeNode value = (MainTreeNode)e.Value;
                Console.WriteLine($"{key}: {value.toString()}");
            }

        }


        public static Hashtable createHashTable(MainTree newMainTree) {
            Hashtable hashtable = new Hashtable();
            newMainTree.addToHashTable(hashtable);
            return hashtable;
        }

        public static void printMaxDepth(MainTree newMainTree) {
            Console.WriteLine("\n\nMax depth is {0}. Informations of subTree that has max depth:\n", newMainTree.getMaxDepth()); // Display the max depth with .getMaxDepth() function.
            newMainTree.subMaxDepth.display(); // Display the subtree that has max depth with .subMaxDepth.display()
            Console.ReadKey();
        }

        public static void printWordTree(MainTree newMainTree, WordTree newWordTree) {
            Console.WriteLine("\n\nEvery word in subtrees printing descending order of their frequencies.");
            newMainTree.addDefinitionsToWordTree(newWordTree); // Add every word in definitions to WordTree
            newWordTree.display(); // Display the WordTree 
            Console.ReadKey();
        }

        public static void AddElementsFromJson(MainTree newMainTree, string jsonFilePath) {

            string jsonString = File.ReadAllText(jsonFilePath);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            List<MainFieldJsonModel> dataList = JsonSerializer.Deserialize<List<MainFieldJsonModel>>(jsonString, options);

            foreach (var mainField in dataList) {
                SubTree currentSubTree = new SubTree();

                foreach (var sub in mainField.Subfields) {
                    currentSubTree.Insert(
                        new SubTreeNode(
                            sub.Name,
                            sub.Description,
                            sub.Application
                        )
                    );
                }

                newMainTree.Insert(new MainTreeNode(mainField.MainFieldName, currentSubTree));
            }
            
        }
    }
}
