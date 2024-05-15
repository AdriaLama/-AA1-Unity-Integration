using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInteract : MonoBehaviour
{
    public GameObject PressE;
    public GameObject PressE2;
    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("ReadThis"))
        {
            PressE.SetActive(true);
        }
        if (collision.gameObject.CompareTag("ReadThis2"))
        {
            PressE2.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("ReadThis"))
        {
            PressE.SetActive(false);
        }
        if (collision.gameObject.CompareTag("ReadThis2"))
        {
            PressE2.SetActive(false);
        }
    }
}
