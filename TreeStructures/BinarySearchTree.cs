namespace TreeStructures;

public class BinarySearchTree(BinarySearchTreeNode root)
{
    BinarySearchTreeNode root { get; set; } = root;


    public BinarySearchTreeNode Search(BinarySearchTreeNode parent, int value)
    {
        if (parent.key == value) return parent;

        if (value > parent.key && parent.right != null)
        {
            return Search(parent.right, value);
        }
    
        if (value < parent.key && parent.left != null)
        {
            return Search(parent.left, value);
        }

        return parent;
    }

    public void Insert(BinarySearchTreeNode root, int value)
    {
        if (root.key == value) return;

        var parent = Search(root, value);

        if (parent == null) return;
        
        if (value > parent.key) parent.right = new BinarySearchTreeNode(value);
        else if (value < parent.key) parent.left = new BinarySearchTreeNode(value);
    }
}