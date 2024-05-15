using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Transition : MonoBehaviour
{

    public AudioMixerSnapshot rain;
    public AudioMixerSnapshot musica;

    public float fastTransition;
   

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Asylum":
                musica.TransitionTo(fastTransition);
                break;
            case "Rain":
                rain.TransitionTo(fastTransition);
                break;

            default:
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            
           case "Asylum":
             rain.TransitionTo(fastTransition);
              break;
            case "Rain":
               musica.TransitionTo(fastTransition);
                break;

            default:
                break;
        }
    }
}
