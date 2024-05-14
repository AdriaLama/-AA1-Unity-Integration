using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject PressE;
    public GameObject PC;
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (PressE.activeSelf)
            {
                PC.SetActive(true);
            }
        }
    }
}
