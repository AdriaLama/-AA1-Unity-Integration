using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.Presets;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject FirstDoor;
    public GameObject DoorMorgue1;
    public GameObject DoorMorgue2;
    public GameObject FirstWindow;
    public GameObject SecondDoor;
    public GameObject SecondWindow;
    public AudioSource openDoorSource;
    public AudioSource closeDoorSource;

    public GameObject DoorBasement;
    public AudioSource DoorSqueak;


    private Quaternion initialRotationFirstDoor;
    private Quaternion initialRotationSecondDoor;
    private Quaternion initialRotationDoorMorgue1;
    private Quaternion initialRotationDoorMorgue2;
    private Quaternion initialRotationDoorBasement;

    private void Start()
    {
        initialRotationFirstDoor = FirstDoor.transform.rotation;
        initialRotationSecondDoor = SecondDoor.transform.rotation;
        initialRotationDoorBasement = DoorBasement.transform.rotation;
        initialRotationDoorMorgue1 = DoorMorgue1.transform.rotation;
        initialRotationDoorMorgue2= DoorMorgue2.transform.rotation;
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Puerta1"))
        {
            FirstDoor.transform.rotation = initialRotationFirstDoor * Quaternion.Euler(0, -80, 0);
            FirstWindow.SetActive(false);
            SecondDoor.transform.rotation = initialRotationSecondDoor * Quaternion.Euler(0, -80, 0);
            SecondWindow.SetActive(false);
            openDoorSource.Play();
        }
        if (collision.gameObject.CompareTag("PuertaSotano"))
        {
            StartCoroutine(AbrirPuerta());
        }
        if (collision.gameObject.CompareTag("PuertaMorgue"))
        {
            DoorMorgue1.transform.rotation = initialRotationDoorMorgue1 * Quaternion.Euler(0, -80, 0);
            DoorMorgue2.transform.rotation = initialRotationDoorMorgue2 * Quaternion.Euler(0, -80, 0);
            openDoorSource.Play();
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Puerta1"))
        {
            FirstDoor.transform.rotation = initialRotationFirstDoor;
            FirstWindow.SetActive(true);
            SecondDoor.transform.rotation = initialRotationSecondDoor;
            SecondWindow.SetActive(true);
            closeDoorSource.Play();
        }
        if (collision.gameObject.CompareTag("PuertaMorgue"))
        {
            DoorMorgue1.transform.rotation = initialRotationDoorMorgue1;
            DoorMorgue2.transform.rotation = initialRotationDoorMorgue2;
            closeDoorSource.Play();
        }
    }

    public IEnumerator AbrirPuerta()
    {
        if (DoorSqueak != null)
        {
            DoorSqueak.Play();
            for (int i = 0; i < 125; i++)
            {
                yield return new WaitForSeconds(0.025f);
                DoorBasement.transform.rotation = initialRotationDoorBasement * Quaternion.Euler(0, -i, 0);
            }
            Destroy(DoorSqueak);
        }
    }
}
