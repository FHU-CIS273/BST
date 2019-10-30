using System;
namespace BST
{

    public class Node<T>
    {
        int Key { get; set; }
        T Data { get; set; }

        Node<T> Left { get; set; }
        Node<T> Right { get; set; }

        public Node(int key)
        {
            Key = key;
            Left = Right = null;
        }

    }

    public class BinarySearchTree<T>
    {
        Node<T> root;

        public BinarySearchTree()
        {
        }
    }
}
