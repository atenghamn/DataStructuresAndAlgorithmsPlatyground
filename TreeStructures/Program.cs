using TreeStructures;


var rootNode = new BinarySearchTreeNode(8);
var tree = new BinarySearchTree(rootNode);
tree.Insert(rootNode, 4);
tree.Insert(rootNode, 1);
tree.Insert(rootNode, 7);
tree.Insert(rootNode, 12);
tree.Insert(rootNode, 9);
tree.Insert(rootNode, 14);
const int searchValue = 1;
var foundNode = tree.Search(rootNode, searchValue);
Console.WriteLine($"Find {searchValue}: found {foundNode.key}");