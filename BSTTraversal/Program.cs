using System;
using System.Collections.Generic;

public class Program
{
    public static List<int> InOrderTraverse(BST tree, List<int> array)
    {
        InOrderTraverseInternal(tree, array);        
        return array;
    }
    public static void InOrderTraverseInternal(BST tree, List<int> array)
    {
        if (tree != null)
        {
            InOrderTraverse(tree.left, array);
            array.Add(tree.value);
            InOrderTraverse(tree.right, array);
        }
    }

    public static List<int> PreOrderTraverse(BST tree, List<int> array)
    {
        PreOrderTraverseInternal(tree, array);
        return array;
    }
    public static void PreOrderTraverseInternal(BST tree, List<int> array)
    {
        if (tree != null)
        {
            array.Add(tree.value);
            PreOrderTraverse(tree.left, array);
            PreOrderTraverse(tree.right, array);
        }
    }

    public static List<int> PostOrderTraverse(BST tree, List<int> array)
    {
        PostOrderTraverseInternal(tree, array);
        return array;
    }
    public static void PostOrderTraverseInternal(BST tree, List<int> array)
    {
        if (tree != null)
        {
            PostOrderTraverseInternal(tree.left, array);
            PostOrderTraverseInternal(tree.right, array);
            array.Add(tree.value);
        }
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }
}
