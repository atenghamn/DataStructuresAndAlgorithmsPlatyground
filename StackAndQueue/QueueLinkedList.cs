namespace StackAndQueue;

public class QueueLinkedList
{
    private static LinkedListNode<int>? _first = null;
    private static LinkedListNode<int>? _last = null;
    public static LinkedList<int> List = [];
    
    
    public void Enqueue(int value)
    {
        var newNode = new LinkedListNode<int>(value);
        _first ??= newNode;
        _last = newNode; 
        List.AddLast(newNode);
    }
    
    public void Dequeue()
    {
        var temp = _first;
        if (_first is not null) 
        {
            _first = _first.Next;
            List.RemoveFirst();
        }
        Console.WriteLine($"Removed element {temp.Value}");
    }
    
    public void PrintQueue()
    {
        var currentNode = _first;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode?.Value);
            currentNode = currentNode?.Next;
        }
        
    }
}