using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class SettingsMenuScript : MonoBehaviour
{
    [Header("REFERENCES")]

    [Space][Header("- Object Ref")]
    public GameObject sourceObj;

    [Space][Header("- Audio Ref")]
    public AudioSource targetObjBgm;
    public AudioSource targetObjSfx;

    [Space][Header("- Slider Ref")]
    public Slider sliderSens;
    public Slider sliderBgm;
    public Slider sliderSfx;

    void Start()
    {
        sliderSens   = GameObject.Find("Sens").GetComponent<Slider>();
        sliderBgm    = GameObject.Find("Bgm").GetComponent<Slider>();
        sliderSfx    = GameObject.Find("Sfx").GetComponent<Slider>();

        sourceObj    = GameObject.Find("Main Camera");
        targetObjBgm = sourceObj.GetComponents<AudioSource>()[0];
        targetObjSfx = sourceObj.GetComponents<AudioSource>()[1];

        setDefaultValue();
    }

    void Update()
    {
        changeValue();
    }

    private void changeValue()
    {
        if (targetObjBgm.volume != sliderBgm.value)
            targetObjBgm.volume = sliderBgm.value;

        if (targetObjSfx.volume != sliderSfx.value)
            targetObjSfx.volume = sliderSfx.value;
    }

    private void setDefaultValue()
    {
        sliderBgm.value = targetObjBgm.volume;
        sliderSfx.value = targetObjSfx.volume;
    }
}
