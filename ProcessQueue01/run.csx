using System;

public static void Run(string myQueueItem, TraceWriter log)
{
    log.Info($"log level: {log.Level}");

    log.Info("This is an Info level message.");
    log.Verbose("This is a Verbose level message.");
    log.Info("This is the second Info level message.");
}