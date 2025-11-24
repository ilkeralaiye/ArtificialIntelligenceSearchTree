namespace ArtificialIntelligenceSearchTree {
    internal class Program {
        static void Main(string[] args) {

            // MACHINE LEARNING
            SubTree mlSubTree = new SubTree();

            mlSubTree.Insert(new SubTreeNode(
                "Deep Learning",
                "A subset of machine learning based on artificial neural networks with multiple layers",
                "Facial recognition systems used in security and smartphones"
            ));

            Console.WriteLine("First node added.");

            mlSubTree.Insert(new SubTreeNode(
                "Reinforcement Learning",
                "A method where an agent learns to make decisions by performing actions and receiving rewards or penalties",
                "AI systems playing complex games like Chess or Go (e.g., AlphaGo)"
            ));

            mlSubTree.Insert(new SubTreeNode(
                "Supervised Learning",
                "Training a model on a labeled dataset where the correct output is known",
                "Email spam filters that learn to distinguish between \"spam\" and \"ham\""
            ));

            mlSubTree.Insert(new SubTreeNode(
                "Unsupervised Learning",
                "Using machine learning algorithms to analyze and cluster unlabeled datasets",
                "Customer segmentation in marketing based on purchasing behavior"
            ));

            MainTreeNode mlMainNode = new MainTreeNode("Machine Learning", mlSubTree);
        
            // COMPUTER VISION
            SubTree cvSubTree = new SubTree();

            cvSubTree.Insert(new SubTreeNode(
                "Facial Recognition",
                "A biometric software application capable of uniquely identifying or verifying a person",
                "Security checkpoints and unlocking mobile devices (FaceID)"
            ));

            cvSubTree.Insert(new SubTreeNode(
                "Image Classification",
                "The process of assigning a specific label or category to an entire image",
                "Automatic photo tagging in Google Photos (e.g., identifying cats or beaches)"
            ));

            cvSubTree.Insert(new SubTreeNode(
                "Object Detection",
                "Identifying and locating objects within an image by drawing bounding boxes around them",
                "Autonomous vehicles detecting pedestrians, traffic signs, and other cars"
            ));

            cvSubTree.Insert(new SubTreeNode(
                "Semantic Segmentation",
                "Linking each pixel in an image to a class label for precise understanding",
                "Medical imaging analysis to detect tumors at pixel level"
            ));

            MainTreeNode cvMainNode = new MainTreeNode("Computer Vision", cvSubTree);


            // NATURAL LANGUAGE PROCESSING 
            SubTree nlpSubTree = new SubTree();

            nlpSubTree.Insert(new SubTreeNode(
                "Machine Translation",
                "Automated translation of text or speech from one natural language to another",
                "Real-time translation tools like Google Translate or DeepL"
            ));

            nlpSubTree.Insert(new SubTreeNode(
                "Sentiment Analysis",
                "The process of determining the emotional tone (positive, negative, neutral) behind a text",
                "Analyzing customer reviews to monitor brand reputation"
            ));

            nlpSubTree.Insert(new SubTreeNode(
                "Speech Recognition",
                "The ability of a machine to identify and process human speech into a written format",
                "Virtual assistants like Siri, Alexa, or Google Assistant"
            ));

            nlpSubTree.Insert(new SubTreeNode(
                "Text Summarization",
                "The process of shortening a set of data computationally to create a subset that represents the most important information",
                "Generating quick news digests from long articles"
            ));

            MainTreeNode nlpMainNode = new MainTreeNode("Natural Language Processing", nlpSubTree);

            // ROBOTICS
            SubTree roboticsSubTree = new SubTree();

            roboticsSubTree.Insert(new SubTreeNode(
                "Human-Robot Interaction",
                "The study of interactions and communication between humans and robots",
                "Caregiver robots assisting elderly patients in healthcare settings"
            ));

            roboticsSubTree.Insert(new SubTreeNode(
                "Medical Robotics",
                "Robots utilized in the medical sciences, including surgery and rehabilitation",
                "Da Vinci Surgical System for precise, minimally invasive surgeries"
            ));

            roboticsSubTree.Insert(new SubTreeNode(
                "Robot Motion Planning",
                "Determining a path for a robot to move from a starting point to a goal without colliding with obstacles",
                "Automated guided vehicles (AGVs) used in warehouse logistics (Amazon Kiva)"
            ));

            roboticsSubTree.Insert(new SubTreeNode(
                "Swarm Robotics",
                "Coordination of large numbers of mostly simple physical robots",
                "Search and rescue missions using drone swarms to cover large areas"
            ));

            MainTreeNode roboticsMainNode = new MainTreeNode("Robotics", roboticsSubTree);



            MainTree newMainTree = new MainTree();

            newMainTree.Insert(mlMainNode);
            newMainTree.Insert(cvMainNode);
            newMainTree.Insert(nlpMainNode);
            newMainTree.Insert(roboticsMainNode);

            newMainTree.display();

            Console.WriteLine("\n\nMax depth is {0}. Informations of subTree that has max depth:\n", newMainTree.getMaxDepth());
            newMainTree.subMaxDepth.display();
            Console.ReadKey();


        }
    }
}
