using System;
using System.Collections.Generic;

namespace TreeNode
{
    internal class Program
    {
        // Node
        public class TreeNode<T>
        {
            public T Data { get; set; }
            public List<TreeNode<T>> Children { get; set; }

            public TreeNode(T data)
            {
                Data = data;
                Children = new List<TreeNode<T>>();
            }

            public void AddChild(TreeNode<T> child)
            {
                Children.Add(child);
            }
        }

        // Tree 
        public class Tree<T>
        {
            public TreeNode<T> Root { get; set; }

            public Tree(T data)
            {
                Root = new TreeNode<T>(data);
            }

            public void Traverse(TreeNode<T> node)
            {
                if (node == null) return;

                Console.WriteLine(node.Data + " ");

                foreach (var child in node.Children)
                {
                    Traverse(child);
                }
            }
        }

        static void Main(string[] args)
        {
            // create Tree
            Tree<string> tree = new Tree<string>("Root");

            // add node
            TreeNode<string> node1 = new TreeNode<string>("Node 1");
            TreeNode<string> node2 = new TreeNode<string>("Node 2");
            TreeNode<string> node3 = new TreeNode<string>("Node 3");

            tree.Root.AddChild(node1);
            tree.Root.AddChild(node2);
            tree.Root.AddChild(node3);

            // add child node
            TreeNode<string> node4 = new TreeNode<string>("Node 4");
            TreeNode<string> node5 = new TreeNode<string>("Node 5");

            node1.AddChild(node4);
            node1.AddChild(node5);

            tree.Traverse(tree.Root);

        }
    }
}