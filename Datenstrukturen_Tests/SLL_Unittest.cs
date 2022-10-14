

using NUnit.Framework;
using SingleLinkedList;

namespace Testproject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void SLL_count_test()
        {
            SingleLinkedListClass llist = new SingleLinkedListClass();
            var myLL = new SingleLinkedListClass();
            Node node = new Node(1);
            myLL.insertLast(1);
            myLL.insertLast(1);
            myLL.insertLast(1);
            myLL.insertLast(1);
            Assert.AreEqual(4, myLL.countNodes());

        }

        [Test]
        public void InsertLast_MultipleElements_ElementsAreInsertedInFront()
        {
            SingleLinkedListClass llist = new SingleLinkedListClass();
            var myLL1 = new SingleLinkedListClass();
            myLL1.insertLast(1);
            myLL1.insertLast(1);
            myLL1.insertLast(5);
            var node = myLL1.GetNode_at_Position(2);
            Assert.AreEqual(5, node.data);
            
        }

        [Test]
        public void TestGetNode_NodeExists_ReturnsNode()
        {
            SingleLinkedListClass llist = new SingleLinkedListClass();
            var myLL1 = new SingleLinkedListClass();
            myLL1.insertLast(1);
            myLL1.insertLast(1);
            myLL1.insertLast(5);
            var node = myLL1.GetNode(1);
            Assert.AreEqual(5, node.data);
        }

        [Test]
        public void TestInsertFirst_MultipleElements_ElementsAreAddedAtTheEnd()
        {
            SingleLinkedListClass llist = new SingleLinkedListClass();
            var myLL1 = new SingleLinkedListClass();
            myLL1.insertFirst(1);
            myLL1.insertFirst(1);
            myLL1.insertFirst(5);
            var node = myLL1.GetNode_at_Position(0);
            Assert.AreEqual(5, node.data);
        }

        [Test]
        public void TestInsertAfter_MultipleElements_ElementsAreAddedAtTheEnd()
        {
            SingleLinkedListClass llist = new SingleLinkedListClass();
            var myLL1 = new SingleLinkedListClass();
            myLL1.insertLast(1);
            myLL1.insertLast(2);
            myLL1.insertLast(5);
            var node = myLL1.GetNode_mmu(2);
            myLL1.InsertAfter(node, 3);
            node = myLL1.GetNode_at_Position(0);
            Assert.AreEqual(1, node.data);
            Assert.AreEqual(2, node.next.data);
            Assert.AreEqual(3, node.next.next.data);
        }

        [Test]
        public void TestDelete_ElementInTheMiddle_ElementIsDeleted()
        {
            SingleLinkedListClass llist = new SingleLinkedListClass();
            var myLL1 = new SingleLinkedListClass();
            myLL1.insertLast(1);
            myLL1.insertLast(2);
            myLL1.insertLast(3);
            myLL1.insertLast(5);
            var node = myLL1.GetNode_mmu(3);
            myLL1.Delete(node);
            node = myLL1.GetNode_at_Position(0);
            Assert.AreEqual(1, node.data);
            Assert.AreEqual(2, node.next.data);
            Assert.AreEqual(5, node.next.next.data);
        }

        [Test]
        public void TestGetNode_NodeDoesExists_ReturnsNull()
        {
            SingleLinkedListClass llist = new SingleLinkedListClass();
            var myLL1 = new SingleLinkedListClass();
            myLL1.insertLast(1);
            myLL1.insertLast(1);
            myLL1.insertLast(5);
            var node = myLL1.GetNode(42);
            Assert.AreEqual(null, node);
        }
    }
}