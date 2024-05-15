using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject PressE;
    public GameObject WheelChair;
    public GameObject PressE2;
    public GameObject Note;
    public GameObject Note2;
    public GameObject RedMessage;
    public AudioSource ReadNote;
    public bool hasRead = false;
    public bool sawWheelChair = false;
    public AudioSource WheelChairSound;
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            if (PressE.activeSelf)
            {
                Note.SetActive(true);
                StartCoroutine(QuitarNota());
                RedMessage.SetActive(true);
                ReadNote.Play();
            }
            if (PressE2.activeSelf)
            {
                Note2.SetActive(true);
                hasRead = true;
                StartCoroutine(QuitarNota());
                ReadNote.Play();
            }
        }
        if(hasRead && !sawWheelChair) 
        { 
            WheelChair.SetActive(true);
            StartCoroutine(MoveChair());
            sawWheelChair = true;
        }

    }

    public IEnumerator QuitarNota()
    {
        yield return new WaitForSeconds(2f);

        Note.SetActive(false);
        Note2.SetActive(false);
    }

    public IEnumerator MoveChair()
    {
        yield return new WaitForSeconds(5f);
        WheelChairSound.Play();

        for (float i = 23; i > 19; i-= 0.1f)
        {
            yield return new WaitForSeconds(0.1f);
            WheelChair.transform.position = new Vector3(i, -3.81f, -18.718f);

        }
        WheelChair.SetActive(false);
        Destroy(WheelChairSound);
    }
}
