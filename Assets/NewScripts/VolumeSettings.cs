using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider slider;
    void Start (){
        if(PlayerPrefs.HasKey("musicVolume")){
            LoadVolume();
        }else{
            SetMusicVolume();
        }
        
    }
    public void SetMusicVolume(){
        float volume = slider.value;
        mixer.SetFloat("Volume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    private void LoadVolume() {
        slider.value = PlayerPrefs.GetFloat("musicVolume",0f);/////////////
        SetMusicVolume();
    }
}
