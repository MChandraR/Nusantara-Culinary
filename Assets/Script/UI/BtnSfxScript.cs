using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnSfxScript : MonoBehaviour,IPointerEnterHandler
{

    public GameObject mainUI;

    private void Start()
    {
        mainUI = GameObject.Find("MainUI").gameObject;
    }

    private void OnMouseOver()
    {
       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (mainUI != null)
        {
            mainUI.GetComponent<MainMenuScript>().PlayBtnSFX();
        }
    }

}
