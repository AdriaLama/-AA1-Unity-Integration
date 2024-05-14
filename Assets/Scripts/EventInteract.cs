using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInteract : MonoBehaviour
{
    public GameObject PressE;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            PressE.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            PressE.SetActive(false);
        }
    }
}
