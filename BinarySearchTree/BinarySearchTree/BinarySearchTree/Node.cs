using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        Node left, right;
        int data;
        private object value;
        public Node(int data)
        {
            if (left == null)
            {
                left = new Node(value);
            }
            else
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.insert(value);
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

        public void printInOrder()
        {
            if (left != null)
            {
                left.printInOrder();
            }
            System.out.printIn(data);
            if (right != null)
            {
                right.printInOrder();
            }
        }

        private void printIn(int data)
        {
            throw new NotImplementedException();
        }
    }
}