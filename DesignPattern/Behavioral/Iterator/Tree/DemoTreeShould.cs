using System;
using System.Xml.Serialization;
using System.Linq;

namespace DesignPattern.Behavioral.Iterator.Tree
{
    public class DemoTreeShould
    {
        public void StartEmpty()
        {
            var myTree = new DemoTree<string>();

            Assert.IsNull(myTree.Value);
        }
        public void StoreValueInRootNode()
        {
            int expectedValue = 1;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.Value);
        }
        public void StoreSecondValueInLeftNode()
        {
            int expectedValue = 2;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.LeftChild.Value);
        }
        public void StoreThirdValueInRightNode()
        {
            int expectedValue = 3;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.RightChild.Value);
        }
        public void StoreFourthValueInLeftLeftNode()
        {
            int expectedValue = 4;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.LeftChild.LeftChild.Value);
        }
        public void StoreFifthValueInLeftRightNode()
        {
            int expectedValue = 5;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            Assert.AreEqual(expectedValue, myTree.LeftChild.RightChild.Value);
        }
        public void StoreSixthValueInRightLeftNode()
        {
            int expectedValue = 6;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            DisplayTree(myTree);
            Assert.AreEqual(expectedValue, myTree.RightChild.LeftChild.Value);
        }
        public void ListValuesInDepthFirstOrder()
        {
            int expectedValue = 6;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            DisplayTree(myTree);
            var valuesString = String.Join(" ", myTree.ToList().ToArray());

            Assert.AreEqual("1 2 4 5 3 6", valuesString);
        }
        public void ListValuesInDepthFirstOrderWithEnumerator()
        {
            int expectedValue = 6;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);

            DisplayTree(myTree);
            var valuesString = String.Join(" ", myTree.ToArray());

            Assert.AreEqual("1 2 4 5 3 6", valuesString);
        }
        public void ListValuesInBreadthFirstOrderWithEnumerator()
        {
            int expectedValue = 14;
            DemoTree<int> myTree = CreateTreeWithValues(expectedValue);
            myTree.UseBreadthFirstEnumerator = true;

            DisplayTree(myTree);
            var valuesString = String.Join(" ", myTree.ToArray());

            Assert.AreEqual("1 2 3 4 5 6 7 8 9 12 13 10 11 14", valuesString);
        }
        public void InitialTreeHasDepthZero()
        {
            var myTree = new DemoTree<int>();
            myTree.Add(1);

            Assert.AreEqual(0, myTree.Depth());
        }
        private DemoTree<int> CreateTreeWithValues(int numberOfValues)
        {
            if (numberOfValues <= 0) return null;

            var tree = new DemoTree<int>(1);
            for (int i = 2; i <= numberOfValues; i++)
            {
                tree.Add(i);
            }
            return tree;
        }
        public void DisplayTree(DemoTree<int> tree )
        {
            var serializer = new XmlSerializer(tree.GetType());
            serializer.Serialize(Console.Out, tree);
        }
    }
}