using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject PressE;
    public GameObject Note;
    public GameObject RedMessage;
    public AudioSource ReadNote;
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
        }
    }

    public IEnumerator QuitarNota()
    {
        yield return new WaitForSeconds(2f);

        Note.SetActive(false);
    }
}
