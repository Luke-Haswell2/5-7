using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class Menu : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    public const string MIXER_MUSIC = "MusicVolume";
    public const string MIXER_SFX = "SFXVolume";

    public AudioSource[] audios_Music;
    public AudioSource[] audios_SFX;
    public Toggle musictoggle;

    
    void Awake()
    {
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);
    }
    void start()
    {
        musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f);
        sfxSlider.value = PlayerPrefs.GetFloat(AudioManager.SFX_KEY, 1f);
    }
    void OnDisable()
    {
     PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, musicSlider.value);
     PlayerPrefs.SetFloat(AudioManager.SFX_KEY, sfxSlider.value);
    }
    void SetMusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }

    void SetSFXVolume(float value)
    {
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);
    }
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
        if (musictoggle.isOn == true)
        {
            logic = 1;
            musicSlider.interactable = true;
            SetMusicVolume(PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY));
        }
        else if (musictoggle.isOn == false)
        {
            logic = 0;
            musicSlider.interactable = false;
            mixer.SetFloat(MIXER_MUSIC, -79);
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
