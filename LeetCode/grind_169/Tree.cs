using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.grind_169
{
    internal class Tree
    {
        public class TreeNode
        {
            public TreeNode? left { get; set; }
            public TreeNode? right { get; set; }
            public int value { get; set; }

            public TreeNode(int value) { 
                this.left = null;
                this.right = null;
                this.value = value;
            }
        }

        public class BinarySearchTree
        {
            private TreeNode? root;
            public BinarySearchTree()
            {
                this.root = null;
            }

            public TreeNode Root 
            {
                get { return this.root!; }
            }

            public void insert(int value)
            {
                // Check whether root is null. Assign a value to root if it is null.
                TreeNode newNode = new TreeNode(value);
                if (this.root == null)
                {
                    this.root = new TreeNode(value);
                    return;
                }

                TreeNode currentNode = this.root;

                /*
                 if the value of newNode is greater than or less than the value of currentNode,
                 check if currentNode.left or currentNode.right is null.

                 if either currentNode.left or currentNode.right is null, assign the value to appropriate node.
                 Otherwise, use an iterator change currentNode to currentNode.left or currentNode.right.
                 */
                while (true) {
                    if (currentNode.value > value)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = newNode;
                            return;
                        }
                        currentNode = currentNode.left;
                    }
                    else if (currentNode.value < value) {
                        if (currentNode.right == null) {
                            currentNode.right = newNode;
                            return;
                        }
                        currentNode = currentNode.right;
                    }
                }
            }

            public TreeNode? Lookup(int value)
            {
                if (this.root == null)
                {
                    return null;
                }

                TreeNode currentNode = this.root;

                while (currentNode != null)
                {
                    if (currentNode.value > value)
                    {
                        currentNode = currentNode.left!;
                    }
                    else if (currentNode.value < value)
                    {
                        currentNode = currentNode.right!;
                    }
                    else
                    {
                        return currentNode;
                    }
                }
                return null;
            }

            public void Remove(int val)
            {
                this.root = Remove(this.root!, val);
            }

            private TreeNode Remove(TreeNode node, int val)
            {
                if (node == null)
                {
                    return null;
                }
                Console.WriteLine(1);

                if (val < node.value)
                {
                    node.left = Remove(node.left!, val);
                    Console.WriteLine(2);
                }
                else if (val > node.value)
                {
                    node.right = Remove(node.right!, val);
                    Console.WriteLine(3);
                }
                else 
                // have found value we want to remove
                {
                    // Case 1: No child or only one child
                    if (node.left == null)
                    {
                        Console.WriteLine(4);
                        return node.right;
                    }
                    else if (node.right == null) 
                    {
                        Console.WriteLine(5);
                        return node.left;
                    }

                    Console.WriteLine(6);
                    // Case 2: Two children
                    TreeNode minNode = FindMin(node.right);
                    node.value = minNode.value;
                    node.right = Remove(node.right, minNode.value);
                }
                Console.WriteLine(7);
                return node;
            }

            private TreeNode FindMin(TreeNode node) {
                while (node.left != null) {
                    node = node.left;
                }
                return node;
            }

            public static void Visualize(TreeNode root, char indent)
            {
                BinarySearchTree bst = new BinarySearchTree();
                bst.PrintTree(root, indent, "None");
                Console.WriteLine("Print End");
            }

            private int indent_num = 0;
            private void PrintTree(TreeNode node, char indent, string direction)
            {
                if (node == null)
                {
                    return;
                }
                indent_num++;
                
               
                if (direction == "right")
                {
                    Console.WriteLine($"{node.value}".PadLeft(indent_num, indent));
                }
                else if (direction == "left") {
                    Console.WriteLine($"{node.value}".PadRight(indent_num, indent));
                }
                else
                {
                    Console.WriteLine($"{node.value}");
                }
                PrintTree(node.right, indent, "right");
                PrintTree(node.left, indent, "left");


            }
        }
    }
}
