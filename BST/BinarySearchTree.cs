using System;
using System.Collections.Generic;

namespace BST
{

    public class Node<T>
    {
        public int Key { get; set; }
        public T Data { get; set; }

        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(int key, T data)
        {
            Key = key;
            Data = data;
            Left = Right = null;
        }

    }

    public class BinarySearchTree<T>
    {
        Node<T> root = null;

        public BinarySearchTree()
        {
        }

        public Node<T> Search(int key)
        {
            return SearchRecursive(root, key);
        }

        private Node<T> SearchRecursive(Node<T> node, int key)
        {
            if (node != null)
            {
                if (key == node.Key)
                {
                    return node;
                }
                else if (key < node.Key)
                {
                    return SearchRecursive(node.Left, key);
                }
                else
                {
                    return SearchRecursive(node.Right, key);
                }
            }

            return null;
        }

        public void Insert(int key, T data)
        {
            var newNode = new Node<T>(key, data);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                InsertRecursive(root, newNode);
            }
        }

        // TODO 
        private void InsertRecursive(Node<T> parent, Node<T> newNode)
        {
            
        }

        // TODO
        public bool Remove(int key)
        {
            // find the node with the given key

            // find the parent

            // call RemoveRecursive(parent, node)

            return true;
        }

        // TODO
        private bool RemoveRecursive(Node<T> parent, Node<T> node)
        {
            return true;
        }

        // TODO
        public int Height
        {
            get
            {
                return 0;
            }
        }

        public Node<T> Parent(Node<T> node)
        {
            return ParentRecursive(root, node);
        }

        // TODO
        private Node<T> ParentRecursive(Node<T> subtreeRoot, Node<T> node)
        {
            return null;
        }


        
        public List<int> InOrderKeys
        {
            get
            {
                List<int> keys = new List<int>();
                InOrderKeysRecursive(root, keys);
                return keys;

            }
        }

        
        private void InOrderKeysRecursive(Node<T> node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            InOrderKeysRecursive(node.Left, list);
            list.Add(node.Key);
            InOrderKeysRecursive(node.Right, list);
        }


        
        public List<int> PreOrderKeys
        {
            get
            {
                List<int> keys = new List<int>();
                PreOrderKeysRecursive(root, keys);
                return keys;
            }
        }

        // TODO
        private void PreOrderKeysRecursive(Node<T> node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            list.Add(node.Key);
            PreOrderKeysRecursive(node.Left, list);
            PreOrderKeysRecursive(node.Right, list);
        }

        
        public List<int> PostOrderKeys
        {
            get
            {
                List<int> keys = new List<int>();
                PostOrderKeysRecursive(root, keys);
                return keys;
            }
        }
        // TODO
        private void PostOrderKeysRecursive(Node<T> node, List<int> list)
        {
          
        }



    }
}
