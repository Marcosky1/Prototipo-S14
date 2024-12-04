using UnityEngine;

// Publisher
public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Evento Publicado: SPACE");
            EventBus.Publish("OnSpacePressed");
        }
    }
}

// Subscriber
public class EventSubscriber : MonoBehaviour
{
    void OnEnable()
    {
        EventBus.Subscribe("OnSpacePressed", OnSpacePressed);
    }

    void OnDisable()
    {
        EventBus.Unsubscribe("OnSpacePressed", OnSpacePressed);
    }

    void OnSpacePressed()
    {
        Debug.Log("Evento Recibido en " + gameObject.name);
    }
}
