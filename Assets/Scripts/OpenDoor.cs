using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.Presets;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject FirstDoor;
    public GameObject SecondDoor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FirstDoor.transform.rotation = Quaternion.Euler(-180, -80, 0);
            SecondDoor.transform.rotation = Quaternion.Euler(0, 80, 0);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FirstDoor.transform.rotation = Quaternion.Euler(-180, -180, 0);
            SecondDoor.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
