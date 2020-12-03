using DotNetCore.CAP;
using Microsoft.Extensions.Logging;
using System;

public class SubscriberService : ICapSubscribe
{
    [CapSubscribe("HelloWorld",Group = "MyGroup")]
    public void CheckReceivedMessage(DateTime datetime)
    {
        Console.Write(datetime);
    }
}