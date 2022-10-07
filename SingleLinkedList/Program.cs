
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
        llist.GetNode(6);
        llist.Delete(6);
        llist.printList();




    }
}
