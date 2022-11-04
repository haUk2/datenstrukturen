
using SingleLinkedList;

class Program
{
    public static void Main(string[] args)
    {
        SingleLinkedListClass llist = new SingleLinkedListClass();
        llist.insertLast(1);
        llist.insertLast(2);
        llist.insertFirst(5);
        llist.insertLast(6);

        Console.WriteLine("List before Insertion Sort: ");
        llist.printList();


        var node = llist.GetNode_mmu(5);


        llist.insertionSort(node);

        Console.WriteLine("List after Insertion Sort: ");
        llist.printList();
    }
}
