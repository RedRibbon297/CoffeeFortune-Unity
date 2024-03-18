using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnButton : MonoBehaviour
{
    public AudioSource soundPlay;

    public void PlayAudioOnButton()
    {
        soundPlay.Play();
    }
}
