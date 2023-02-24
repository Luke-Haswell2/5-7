using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    //[SerializeField] AudioMixer mixerMusic;
    //[SerializeField] AudioMixer mixerSFX;
    //public static AudioManager instance;
    //public const string MUSIC_KEY = "musicVolume";
    //public const string SFX_KEY = "sfxVolume";

    //void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    } 
    //    LoadVolume(); 
    //}
    //void LoadVolume()
    //{
    //    float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 1f);
    //    float sfxVolume = PlayerPrefs.GetFloat(SFX_KEY, 1f);
    //    mixerMusic.SetFloat(Menu.MIXER_MUSIC, MathF.Log10(musicVolume) * 20);
    //    mixerSFX.SetFloat(Menu.MIXER_SFX, MathF.Log10(sfxVolume) * 20);
    //}
}
