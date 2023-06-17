using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageUI : MonoBehaviour
{
    GameObject mainCamera;
    public Canvas detailStageUI;

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    }

    void Update()
    {
        if (mainCamera != null)
        {
            this.transform.rotation = new Quaternion(mainCamera.transform.rotation.x,this.transform.rotation.y, this.transform.rotation.z,0.75f);
        }
    }

    public void showDetailStage(string kota)
    {
        Debug.Log("Hallo" + kota);
        detailStageUI.enabled = detailStageUI.enabled ? false : true;
    }
}
