using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public Slider masterSlider;
    public Slider ambianceSlider;
    public Slider vfxSlider;

    public AudioMixer masterMixer;

    // Start is called before the first frame update
    void Start()
    {
        masterSlider.value = PlayerPrefs.GetFloat("Master", 1f);
        ambianceSlider.value = PlayerPrefs.GetFloat("music", 1f);
        vfxSlider.value = PlayerPrefs.GetFloat("SFX", 1f);
        masterMixer.SetFloat("Master", Mathf.Log10(masterSlider.value) * 20);
        masterMixer.SetFloat("Music", Mathf.Log10(ambianceSlider.value) * 20);
        masterMixer.SetFloat("SFX", Mathf.Log10(vfxSlider.value) * 20);

    }

    public void SetMasterVolumeLevel(float volumeLevel)
    {
        masterMixer.SetFloat("Master", Mathf.Log10(volumeLevel) * 20);
        PlayerPrefs.SetFloat("Master", volumeLevel);
    }

    public void SetAmbianceVolumeLevel(float volumeLevel)
    {
        masterMixer.SetFloat("Music", Mathf.Log10(volumeLevel) * 20);
        PlayerPrefs.SetFloat("Music", volumeLevel);
    }

    public void SetVFXVolumeLevel(float volumeLevel)
    {
        masterMixer.SetFloat("SFX", Mathf.Log10(volumeLevel) * 20);
        PlayerPrefs.SetFloat("SFX", volumeLevel);
    }
}
