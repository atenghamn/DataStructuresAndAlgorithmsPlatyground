namespace StackAndQueue;

public class StackLinkedList
{
    private static LinkedListNode<int>? _first = null;
    public static LinkedList<int> List = [];
    
    
    public void Push(int value)
    {
        var newNode = new LinkedListNode<int>(value);
        _first = newNode; 
        List.AddLast(newNode);
    }
    
    public void Pop()
    {
        var temp = _first;
        if (_first is not null) 
        {
            _first = _first.Previous;
            List.RemoveLast();
        }
        if (_first != null) Console.WriteLine($"Removed element {temp.Value}");
    }
    
    public void PrintStack()
    {
        var currentNode = _first;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode?.Value);
            currentNode = currentNode?.Previous;
        }
        
    }
}