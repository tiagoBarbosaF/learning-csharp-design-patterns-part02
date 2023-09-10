using DesignPatternsPart02.Classes.Requests;

namespace DesignPatternsPart02;

internal static class Program
{
    public static void Main(string[] args)
    {
        var workQueue = new WorkQueue();

        var request1 = new Request("Tiago", 100);
        var request2 = new Request("Peter", 200);
        
        workQueue.Add(new PayRequest(request1));
        workQueue.Add(new PayRequest(request2));
        
        workQueue.Add(new FinishRequest(request2));
        
        workQueue.Process();
    }
}