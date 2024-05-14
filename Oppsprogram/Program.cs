using System;
using System.Collections;

namespace Example
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }


    }

    public class BinaryTree
    {
        int indx = -1;

        public Node buildTree(int[] nodes)
        {
            indx++;
            if (indx >= nodes.Length || nodes[indx] == -1)
            {
                return null;
            }

            Node newNode = new Node(nodes[indx]);
            newNode.left = buildTree(nodes);
            newNode.right = buildTree(nodes);
            return newNode;
        }

        public void preorder(Node root)//O(n)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.data+" ");

            preorder(root.left);
            preorder(root.right);
        }
        public void inorder(Node root)//O(n)
        {
            if(root == null)
            {
                return;
            }
            inorder(root.left);
            Console.Write(root.data+" ");
            inorder(root.right);
        }
        public void postorder(Node root)//O(n)
        {
            if (root == null)
            {
                return;
            }
            postorder(root.left);
            postorder(root.right);
            Console.Write(root.data + " ");

        }
        public bool IsEmpty(Node root)
        {
            return root == null;
        }
        public void levelorder(Node root)
        {
            if(root == null)
            {
                return;
            }
            Queue q = new Queue();
            q.Enqueue(root);
            q.Enqueue(null);

            while (q.Count!=0)
            {
                Node currNode = (Node)q.Dequeue();

                if(currNode == null)
                {
                    Console.WriteLine();
                    if (q.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        q.Enqueue(null);
                    }
                }
                else
                {
                    Console.Write(currNode.data + " ");
                    if(currNode.left != null)
                    {
                        q.Enqueue(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        q.Enqueue(currNode.right);
                    }
                }
            }

        }
        public static int countOfNodes(Node root)//O(n)
        {
            if(root == null)
            {
                return 0;
            }
            int leftCount = countOfNodes(root.left);
            int rightCount = countOfNodes(root.right);

            return leftCount + rightCount + 1;
        }
        public static int sumOfNodes(Node root)//O(n)
        {
            if (root == null)
            {
                return 0;
            }
            int leftSum = sumOfNodes(root.left);
            int rightSum = sumOfNodes(root.right);

            return leftSum + rightSum + root.data;
        }

        public static int heightOfNodes(Node root)//O(n)
        {
            if (root == null)
            {
                return 0;
            }
            int leftSum = heightOfNodes(root.left);
            int rightSum = heightOfNodes(root.right);
            int height = Math.Max(leftSum, rightSum)+1;
            return height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nodes = { 1, 2, 4, -1, -1,5,-1,-1, 3, -1, 6, -1, -1 };
            BinaryTree tree = new BinaryTree();
            Node root = tree.buildTree(nodes);
            Console.WriteLine(root.data);
            tree.preorder(root);
            Console.WriteLine();
            tree.inorder(root);
            Console.WriteLine();
            tree.postorder(root);
            Console.WriteLine();
            tree.levelorder(root);

            Console.WriteLine(BinaryTree.countOfNodes(root));
            Console.WriteLine(BinaryTree.sumOfNodes(root));
            Console.WriteLine(BinaryTree.heightOfNodes(root));



        }
    }
}
