namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample
{
    public class Sample : ISample
    {        
        public void Run()
        {
            var bryan = new Director();
            var crystal = new VP();
            var jeff = new CEO();

            bryan.setSuccessor(crystal);
            crystal.setSuccessor(jeff);

            var request = new Request(RequestType.CONFERENCE, 500);
            bryan.handleRequest(request);

            request = new Request(RequestType.PURCHASE, 1000);
            crystal.handleRequest(request);

            request = new Request(RequestType.PURCHASE, 2000);
            bryan.handleRequest(request);
        }
    }
}
