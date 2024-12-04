using System;
using System.Collections.Generic;

public static class EventBus
{
    private static Dictionary<string, Action> events = new Dictionary<string, Action>();

    public static void Subscribe(string eventName, Action listener)
    {
        if (!events.ContainsKey(eventName))
            events[eventName] = () => { };

        events[eventName] += listener;
    }

    public static void Unsubscribe(string eventName, Action listener)
    {
        if (events.ContainsKey(eventName))
            events[eventName] -= listener;
    }

    public static void Publish(string eventName)
    {
        if (events.ContainsKey(eventName))
            events[eventName]?.Invoke();
    }
}
