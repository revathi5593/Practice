using System;

public class Program
{
    public static bool ValidateBst(BST tree)
    {
        return ValidateBstNew(tree, int.MinValue, int.MaxValue);
    }

    private static bool ValidateBstNew(BST tree, int minValue, int maxValue)
    {
        if (tree == null)
            return true;
        // Check if the current node value is within the valid range
        if (tree.value <= minValue || tree.value >= maxValue)
            return false;
        

        // Recursively check left and right subtrees
        return ValidateBstNew(tree.left, minValue, tree.value) &&
               ValidateBstNew(tree.right, tree.value, maxValue);
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
