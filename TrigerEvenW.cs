using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TrigerEvenW : MonoBehaviour
{
    public string Tag;
    public UnityEvent Event;
    public UnityEvent QuitTriggerEvent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Tag)
        {
            Event.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == Tag)
        {
            QuitTriggerEvent.Invoke();
        }
    }
}
