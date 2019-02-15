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
        //I do plan on changing this to a while loop.
        public Node(int data)
        {
            this.data = data;
        }
        public void insert(int value)
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new Node(value);
                }
                else
                {
                    left.insert(value);
                }
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

        public bool contains(int value)
        {
            if (value == data) {
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
            else {
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
    }

    public void printInOrder()
    {
        if (left != null)
        {
            left.printInOrder();
        }
        System.out.println(data);
        if (right != null)
        {
            right.printInOrder();
        }
    }


}