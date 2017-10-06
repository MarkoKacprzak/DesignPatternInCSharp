using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    public class Demo: IDemo
    {
        public string Name => "Chain of responsibility pattern";

        public void Run()
        {
            Director bryan = new Director();
            VP crystal = new VP();
            CEO jeff = new CEO();

            bryan.setSuccessor(crystal);
            crystal.setSuccessor(jeff);

            Request request = new Request(RequestType.CONFERENCE, 500);
            bryan.handleRequest(request);

            request = new Request(RequestType.PURCHASE, 1000);
            crystal.handleRequest(request);

            request = new Request(RequestType.PURCHASE, 2000);
            bryan.handleRequest(request);
        }
    }
}
