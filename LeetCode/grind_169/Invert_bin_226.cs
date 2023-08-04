using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.grind_169
{
    internal class Invert_bin_226
    {
        
        public void GetResult() { 
            Tree.BinarySearchTree bst = new Tree.BinarySearchTree();
            int[] list_val = new int[] { 50, 100,25,70,150,60,80,75,90,140,170 };
            foreach (int i in list_val)
            {
                bst.insert(i);
            }
            Console.WriteLine("bst insert ending");

            Tree.BinarySearchTree.Visualize(bst.Root,'-');

        }
    }
}
