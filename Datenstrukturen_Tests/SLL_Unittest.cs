

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
        public void SLL_insert_first_test()
        {
            SingleLinkedListClass llist = new SingleLinkedListClass();
            var myLL1 = new SingleLinkedListClass();

            myLL1.insertLast(1);
            myLL1.insertLast(1);
            myLL1.insertLast(5);
            
            Assert.AreEqual(5, myLL1.GetNode_at_Position(3));
        }
    }
}