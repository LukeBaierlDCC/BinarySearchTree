using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;

        //Node left, right;
        //int data;
        private object value;
        public Node(int data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;

            //if (left == null)
            //{
            //    left = new Node(value);
            //}
            //else
            //{
            //    if (right == null)
            //    {
            //        right = new Node(value);
            //    }
            //    else
            //    {
            //        right.insert(value);
            //    }
            //}
        }

        public static void PrintTree(Node tree)
        {
            List<Node> firstStack = new List<Node>();
            firstStack.Add(tree);

            List<List<Node>> childListStack = new List<List<Node>>();
            childListStack.Add(firstStack);

            while (childListStack.Count > 0)
            {
                List<Node> childStack = childListStack[childListStack.Count - 1];

                if (childStack.Count == 0)
                {
                    childListStack.RemoveAt(childListStack.Count - 1);
                }
                else
                {
                    tree = childStack[0];
                    childStack.RemoveAt(0);

                    string indent = "";
                    for (int i = 0; i < childListStack.Count - 1; i++)
                    {
                        indent += (childListStack[i].Count > 0) ? "| " : " ";
                    }

                    Console.WriteLine(indent + "+- " + tree.Name);

                    if (tree.Children.Count > 0)
                    {
                        childListStack.Add(new List<Node>(tree.Children));
                    }
                }
            }
        }

        public Node(object value)
        {
            this.value = value;
        }

        private void insert(object value)
        {
            throw new NotImplementedException();
        }

        public bool contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.contains(value);
                }
            }
        }
        
        //public void printInOrder()
        //{
        //    if (left != null)
        //    {
        //        left.printInOrder();
        //    }
        //    System.out.printIn(data);
        //    //if (right != null)
        //    {
        //        right.printInOrder();
        //    }
        //}

        private void printIn(int data)
        {
            throw new NotImplementedException();
        }
    }
}