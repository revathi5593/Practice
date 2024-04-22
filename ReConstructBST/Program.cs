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

    public BST ReconstructBst(List<int> preOrderTraversalValues)
    {
        return ConstructBST(preOrderTraversalValues, 0, preOrderTraversalValues.Count - 1);
    }

    private BST ConstructBST(List<int> preOrderTraversalValues, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        int rootValue = preOrderTraversalValues[start];
        BST root = new BST(rootValue);

        int leftSubtreeEnd = start;
        for (int i = start + 1; i <= end; i++)
        {
            if (preOrderTraversalValues[i] < rootValue)
            {
                leftSubtreeEnd++;
            }
            else
            {
                break;
            }
        }

        root.left = ConstructBST(preOrderTraversalValues, start + 1, leftSubtreeEnd);
        root.right = ConstructBST(preOrderTraversalValues, leftSubtreeEnd + 1, end);

        return root;
    }
}