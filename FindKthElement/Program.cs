using System;
using System.Collections.Generic;

public class Program
{
    // This is an input class. Do not edit.
    public class BST
    {
        public int value;
        public BST left = null;
        public BST right = null;

        public BST(int value)
        {
            this.value = value;
        }
    }

    public int FindKthLargestValueInBst(BST tree, int k)
    {
        Stack<BST> stack = new Stack<BST>();
        BST current = tree;

        // Traverse the tree in reverse in-order (right -> root -> left)
        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.right;
            }

            current = stack.Pop();
            k--;

            if (k == 0)
            {
                return current.value; // Found the kth largest value
            }

            current = current.left;
        }

        // If k is greater than the number of nodes in the tree
        throw new ArgumentException("k is greater than the number of nodes in the tree");
    }
}
