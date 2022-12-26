using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /* A Node class consi*/
    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        //constructor for the node class

        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }
    class BinaryTree
    {
        public node ROOT;

        public BinarySearchTree()
        {
            ROOT = null; //initializing root to null
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
