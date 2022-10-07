using Datenstrukturen;

class Program
{
    public static void Main(string[] args)
    {



        SingleLinkedList llist = new SingleLinkedList();


        llist.head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);

        llist.head.next = second;
        second.next = third;

        llist.insert(5);
        llist.countNodes();
        llist.printList();




    }
}
