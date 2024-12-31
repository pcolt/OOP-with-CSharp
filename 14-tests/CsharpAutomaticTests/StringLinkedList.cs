namespace CsharpAutomaticTests;

public interface IStringLinkedList
{
    int Count { get; }
    void Add(string item);
    void Remove(string item);
    string Get(int index);
}

public class StringLinkedList : IStringLinkedList
{
    private readonly StringLinkedNode _head;
    public int Count { get; private set; }

    public StringLinkedList() {
        _head = new StringLinkedNode();
    }

    public void Add(string item) {
        var newNode = new StringLinkedNode{ 
            Item = item,
            Next = null
        };
        var current = _head;
        while (current.Next != null) {
            current = current.Next;
        }
        current.Next = newNode;
        Count++;
    }

    public void Remove(string item) {
        var current = _head;
        while (current.Next != null) {
            if (current.Next.Item == item) {
                current.Next = current.Next.Next;
                Count--;
                return;
            }
            current = current.Next;
        }
    }

    public string Get(int index) {
        if (index < 0 || index >= Count) {
            throw new IndexOutOfRangeException($"Index {index} is out of range");
        }
        var i = 0;
        var current = _head.Next;
        while (i < index) {
            current = current.Next;
            i++;
        }
        return current.Item;
    }
}

internal class StringLinkedNode
{
    internal string Item;
    internal StringLinkedNode Next;
}
