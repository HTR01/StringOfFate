using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
    }

    public void SetEffectsVolume(float volume)
    {
        Debug.Log(volume);
    }

    public void SetMusicVolume(float volume)
    {
        Debug.Log(volume);
    }
}
