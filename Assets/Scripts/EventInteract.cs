using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInteract : MonoBehaviour
{
    public GameObject PressE;
    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("ReadThis"))
        {
            PressE.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("ReadThis"))
        {
            PressE.SetActive(false);
        }
    }
}
