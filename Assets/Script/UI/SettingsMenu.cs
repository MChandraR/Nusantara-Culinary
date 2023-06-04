using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    // ATTRIBUTES
    [Header("Set Slider")]
    public Slider bgm_slider;

    // UNITY BUILD-IN METHOD
    void Start()
    {
        bgm_slider = GameObject.Find("BGM Volume/Slider").GetComponent<Slider>();
        bgm_slider.value = GameObject.Find("GameManager/Audio").GetComponent<AudioSource>().volume;
    }

    void Update()
    {
        setValueBGM();
    }

    // METHOD
    public void setValueBGM()
    {
        GameObject.Find("GameManager/Audio").GetComponent<AudioSource>().volume = bgm_slider.value;
    }

    public void backButton()
    {
        Debug.Log("Back Button");
    }
}
