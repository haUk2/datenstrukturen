using Datenstrukturen;
using NUnit.Framework;


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
            SingleLinkedList llist = new SingleLinkedList();


            var myLL = new SingleLinkedList();

            Node node = new Node(1);


            myLL.insert(1);
            myLL.insert(1);
            myLL.insert(1);
            myLL.insert(1);
            Assert.AreEqual(4, myLL.countNodes());





        }
    }
}