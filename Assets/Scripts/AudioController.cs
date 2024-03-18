using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Sprite Music_On;
    public Sprite Music_Off;
    public GameObject Button_OffOn_Audio;
    public AudioClip clip;
    public AudioSource audio;
    public float MusicOnOff;
    void Start()
    {
        if (PlayerPrefs.HasKey("MusicOnOff"))
        {
            MusicOnOff = PlayerPrefs.GetFloat("MusicOnOff");
        }
    }

    public void OnOfAudio()
    {
        if(AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
            Button_OffOn_Audio.GetComponent<Image>().sprite = Music_Off;
            MusicOnOff = 1f;
            PlayerPrefs.SetFloat("MusicOnOff", MusicOnOff);
        }
        else
        {
            AudioListener.volume = 1;
            Button_OffOn_Audio.GetComponent<Image>().sprite = Music_On;
            MusicOnOff = 0f;
            PlayerPrefs.SetFloat("MusicOnOff", MusicOnOff);
        }
    }

    public void PlaySound()
    {
        audio.PlayOneShot(clip);
    }
    void Update()
    {
        if(MusicOnOff == 1f)
        {
            AudioListener.volume = 0;
            Button_OffOn_Audio.GetComponent<Image>().sprite = Music_Off;
        }
        else if(MusicOnOff == 0f)
        {
            AudioListener.volume = 1;
            Button_OffOn_Audio.GetComponent<Image>().sprite = Music_On;
        }
    }
}
