using System;

// This code demonstrates the latest implementation pattern for defining, raising, and handling an event using the preferred generic EventHandler<TEventArgs> delegate.
// This latest C# pattern for events is highly idiomatic and relies on three core components: Custom EventArgs, the event keyword, and the null-conditional operator (?.).

// 1. Defining the Contract (Custom EventArgs)
// The custom data payload that the event will carry.
public class StatusUpdateEventArgs : EventArgs
{
    // C# 9+ syntax for concise properties
    public string Message { get; init; }
    public DateTime Timestamp { get; init; }

    public StatusUpdateEventArgs(string message)
    {
        Message = message;
        Timestamp = DateTime.Now;
    }
}

// --- The Publisher (Raiser) ---
// This object defines the event and decides when to fire it.
public class TaskProcessor
{
    // 2. Defining the Event (The latest implementation)
    // We use the generic delegate EventHandler<TEventArgs> where TEventArgs is our custom data type.
    // The 'event' keyword ensures that only the containing class can RAISE the event.
    public event EventHandler<StatusUpdateEventArgs>? StatusUpdated;

    // Method that simulates work and raises the event
    public void StartTask()
    {
        Console.WriteLine("Processor: Starting task...");

        // Simulate work progress
        for (int i = 1; i <= 3; i++)
        {
            System.Threading.Thread.Sleep(500); // Simulate delay

            // 3. Safely Raising the Event
            // The preferred pattern uses the null-conditional operator '?.' (since C# 6)
            // This checks if there are any subscribers before attempting to invoke the event.
            OnStatusUpdated($"Step {i} completed.");
        }

        Console.WriteLine("Processor: Task finished.");
    }

    // A protected virtual method to safely raise the event, allowing derived classes to override it.
    protected virtual void OnStatusUpdated(string message)
    {
        // Check for subscribers and invoke (raise) the event
        StatusUpdated?.Invoke(
            this, // 'this' is the sender (the TaskProcessor instance)
            new StatusUpdateEventArgs(message)
        );
    }
}

// --- The Subscriber (Handler) ---
// This object listens for the event and executes a method when it fires.
public class NotificationService
{
    // The event handling method (the signature MUST match the delegate signature)
    public void HandleStatusUpdate(object? sender, StatusUpdateEventArgs e)
    {
        Console.WriteLine($"\n[Notification Received]");
        Console.WriteLine($"  Message: {e.Message}");
        Console.WriteLine($"  Time: {e.Timestamp.ToLongTimeString()}");
        Console.WriteLine($"  Sender Type: {sender?.GetType().Name}");
        Console.WriteLine("[Notification Processed]");
    }
}

// --- Application Entry Point ---
public class Program
{
    public static void Main()
    {
        // 1. Instantiate the Publisher and Subscriber
        var processor = new TaskProcessor();
        var notifier = new NotificationService();

        // 2. Handling (Subscribing) the Event
        // The '+=' operator is used to hook the subscriber's method to the publisher's event.
        processor.StatusUpdated += notifier.HandleStatusUpdate;

        // Example of a Lambda Expression handler (for simple actions)
        processor.StatusUpdated += (sender, args) =>
        {
            Console.WriteLine($"\n--- Simple Logger: Task progress update: {args.Message} ---");
        };


        // 3. Start the process, which will automatically raise the events
        processor.StartTask();

        // 4. Unsubscribing (optional, but good practice)
        // The '-=' operator removes a handler.
        processor.StatusUpdated -= notifier.HandleStatusUpdate;
    }
}
