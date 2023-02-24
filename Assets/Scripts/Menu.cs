using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class Menu : MonoBehaviour
{
    [SerializeField] AudioMixer mixerMusic;
    [SerializeField] AudioMixer mixerSFX;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    public string MIXER_MUSIC = "MusicVolume";
    public string MIXER_SFX = "SFXVolume";

    public Toggle musictoggle;

    void Start()
    {
        SetVolumeMusic(PlayerPrefs.GetFloat(MIXER_MUSIC));
        SetVolumeSFX(PlayerPrefs.GetFloat(MIXER_SFX));
    }

    public void SetVolumeMusic(float volume)
    {
        musicSlider.value = volume;

        mixerMusic.SetFloat("Volume", volume);
    }
    public void SetVolumeSFX(float volume)
    {
        sfxSlider.value = volume;

        mixerSFX.SetFloat("Volume", volume);
    }
    public void ToggleMusic(int logic)
    {
        if (musictoggle.isOn == true)
        {
            logic = 1;
            musicSlider.interactable = true;
            SetVolumeMusic(0.5f);
        }
        else if (musictoggle.isOn == false)
        {
            logic = 0;
            musicSlider.interactable = false;
            SetVolumeMusic(-50);
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
