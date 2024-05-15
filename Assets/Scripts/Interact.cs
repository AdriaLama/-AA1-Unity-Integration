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
    
        WheelChairSound.Play();
        yield return new WaitForSeconds(5f);

        for (float i = 24; i < 19; i-=0.25f)
        {
            yield return new WaitForSeconds(0.25f);
            WheelChair.transform.position = new Vector3(i, -3.81f, -18.718f);

        }
        Destroy(WheelChairSound);
        sawWheelChair = true;
    }

}
