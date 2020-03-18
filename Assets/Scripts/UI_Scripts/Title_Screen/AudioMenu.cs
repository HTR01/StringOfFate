using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMenu : MonoBehaviour
{
    public AudioMixer masterMixer;
    public AudioMixer effectMixer;
    public AudioMixer musicMixer;

    public void SetMasterVolume(float volume)
    {
        masterMixer.SetFloat("MasterVolume", volume);
    }

    public void SetEffectsVolume(float volume)
    {
        effectMixer.SetFloat("EffectVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        musicMixer.SetFloat("MusicVolume", volume);
    }
}
