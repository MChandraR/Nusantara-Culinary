using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuScript : MonoBehaviour
{
    [Header("References")]
    public Slider sliderSens;
    public Slider sliderBgm;
    public Slider sliderSfx;

    [Header("Slider Config")]
    public float targetObjBgm = new float();

    void Start()
    {
        sliderSens   = GameObject.Find("Sens").GetComponent<Slider>();
        sliderBgm    = GameObject.Find("Bgm").GetComponent<Slider>();
        sliderSens   = GameObject.Find("Sfx").GetComponent<Slider>();

        targetObjBgm = GameObject.Find("Main Camera").GetComponent<AudioSource>().volume;

        setDefaultValue();
    }

    void Update()
    {
        changeValue();
    }

    private void changeValue()
    {
        if(targetObjBgm != sliderBgm.value)
        {
            targetObjBgm = sliderBgm.value;
        }
    }

    private void setDefaultValue()
    {
        sliderBgm.value = targetObjBgm;
    }
}
