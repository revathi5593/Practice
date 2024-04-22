using System;
using System.Collections.Generic;

public class Program
{
    public static BST MinHeightBst(List<int> array)
    {
        // Base case: If the array is empty, return null
        if (array.Count == 0)
        {
            return null;
        }

        // Find the middle index of the array
        int middleIndex = array.Count / 2;

        // Create the root node of the BST
        BST root = new BST(array[middleIndex]);

        // Recursively build the left and right subtrees
        root.left = MinHeightBst(array.GetRange(0, middleIndex));
        root.right = MinHeightBst(array.GetRange(middleIndex + 1, array.Count - middleIndex - 1));

        return root;
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }

        public void insert(int value)
        {
            if (value < this.value)
            {
                if (left == null)
                {
                    left = new BST(value);
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
                    right = new BST(value);
                }
                else
                {
                    right.insert(value);
                }
            }
        }
    }
}