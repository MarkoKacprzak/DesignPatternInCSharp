namespace DesignPattern.Behavioral.Iterator.Tree
{
    public class Sample : ISample
    {
        public void Run()
        {
            var demo = new DemoTreeShould();
            demo.StartEmpty();
            demo.StoreValueInRootNode();
            demo.StoreSecondValueInLeftNode();
            demo.StoreThirdValueInRightNode();
            demo.StoreFourthValueInLeftLeftNode();
            demo.StoreFifthValueInLeftRightNode();
            demo.StoreSixthValueInRightLeftNode();
            demo.ListValuesInDepthFirstOrder();
            demo.ListValuesInDepthFirstOrderWithEnumerator();
            demo.ListValuesInBreadthFirstOrderWithEnumerator();
            demo.InitialTreeHasDepthZero();
        }
    }
}