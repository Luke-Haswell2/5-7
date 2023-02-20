using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public AudioSource[] audios_Music;
    public AudioSource[] audios_SFX;
    public Toggle musictoggle;
    public Slider musicSlider;
    public Slider sfxSlider;
    public GameObject music;

    public void SetVolumeMusic(float volume)
    {
        musicSlider.value = volume;

        foreach (AudioSource audio in audios_Music)
        {
            audio.volume = musicSlider.value;
        }
    }
    public void SetVolumeSFX(float volume)
    { 
        sfxSlider.value = volume;

        foreach (AudioSource audio in audios_SFX)
       {
            audio.volume = sfxSlider.value;
        }
    }
    public void ToggleMusic(int logic)
    {
        if(musictoggle.isOn == true)
        {
            logic = 1;
            musicSlider.interactable = true;
            musicSlider.value = 0.5f;
        }
        else if(musictoggle.isOn == false)
        {
            logic = 0;
            musicSlider.interactable = false;
            musicSlider.value = 0;
        }
    }

    
}
