using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepsOnCeramic;
    public AudioClip[] footstepsOnWood;

    public string material;
    void PlayFootstepSound()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.pitch = Random.Range(0.8f, 1.2f);
        myAudioSource.volume = Random.Range(0.8f, 1.0f);

        switch (material)
        {
            case "Ceramica":
                myAudioSource.PlayOneShot(footstepsOnCeramic[Random.Range(0, footstepsOnCeramic.Length)]);
                break;

            case "Wood":
                myAudioSource.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
                break;

            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ceramica":
            case "Wood":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }

}
