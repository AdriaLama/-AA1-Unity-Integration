using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.Presets;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject FirstDoor;
    public GameObject FirstWindow;
    public GameObject SecondDoor;
    public GameObject SecondWindow;
    public AudioClip openDoor;
    public AudioClip closeDoor;
    public AudioSource openDoorSource;
    public AudioSource closeDoorSource;

    private Quaternion initialRotationFirstDoor;
    private Quaternion initialRotationSecondDoor;

    private void Start()
    {
        initialRotationFirstDoor = FirstDoor.transform.rotation;
        initialRotationSecondDoor = SecondDoor.transform.rotation;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FirstDoor.transform.rotation = initialRotationFirstDoor * Quaternion.Euler(0, -80, 0);
            FirstWindow.SetActive(false);
            SecondDoor.transform.rotation = initialRotationSecondDoor * Quaternion.Euler(0, -80, 0);
            SecondWindow.SetActive(false);
            openDoorSource.PlayOneShot(openDoor);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FirstDoor.transform.rotation = initialRotationFirstDoor;
            FirstWindow.SetActive(true);
            SecondDoor.transform.rotation = initialRotationSecondDoor;
            SecondWindow.SetActive(true);
            closeDoorSource.PlayOneShot(closeDoor);
        }
    }
}
