using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject PressE;
    public GameObject Note;
    public GameObject RedMessage;
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (PressE.activeSelf)
            {
                Note.SetActive(true);
                RedMessage.SetActive(true);
            }
        }
    }
}
