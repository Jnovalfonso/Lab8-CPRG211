using SingleLinkedList;

namespace Testing
{
    [TestFixture]
    public class Tests
    {
        LinkedList linkedList;
        [SetUp]
        public void Setup()
        {
            linkedList = new LinkedList();
        }

        [Test]
        public void TestAddFirst()
        {

            linkedList.AddFirst("Joe Blow");
            linkedList.AddFirst("Joe Schmoe");

            Assert.That(linkedList.Head.Data, Is.EqualTo("Joe Schmoe"));
        }

        [Test]
        public void TestAddLast() 
        {
            linkedList.AddLast("Bob Bobberson");
            linkedList.AddLast("John Smith");
            linkedList.AddLast("Jane Doe");

            Assert.That(linkedList.GetLastNode(), Is.EqualTo("Jane Doe"));
        }

        [Test]
        public void TestRemoveFirst()
        {
            linkedList.AddLast("Sam Sammerson");
            linkedList.AddLast("John Smith");
            linkedList.AddLast("Jane Doe");

            linkedList.RemoveFirst();

            Assert.That(linkedList.Head.Data, Is.EqualTo("John Smith"));
        }

        [Test]
        public void TestRemoveLast()
        {
            linkedList.AddFirst("Joe Schmoe");
            linkedList.AddLast("Bob Bobberson");
            linkedList.AddLast("Sam Sammerson");
            linkedList.AddLast("John Smith");
            linkedList.AddFirst("Dave Daverson");

            linkedList.RemoveLast();

            Assert.That(linkedList.GetLastNode(), Is.EqualTo("Sam Sammerson"));
        }

        [Test]
        public void TestGetValue()
        {
            linkedList.AddFirst("Joe Blow");
            linkedList.AddFirst("Joe Schmoe");
            linkedList.AddLast("Bob Bobberson");
            linkedList.AddLast("John Smith");
            linkedList.AddLast("Jane Doe");

            string indexValue = linkedList.GetValue(1);

            Assert.That(indexValue, Is.EqualTo("Joe Blow"));
        }

        [Test]
        public void TestListCount()
        {
            linkedList.AddLast("Jane Doe");
            linkedList.AddFirst("Joe Schmoe");
            linkedList.AddLast("Bob Bobberson");
            linkedList.AddLast("John Smith");
            linkedList.AddFirst("Joe Blow");
            linkedList.AddLast("Sam Sammerson");
            linkedList.AddFirst("Dave Daverson");

            Assert.That(linkedList.Count, Is.EqualTo(7));
        }
    }
}