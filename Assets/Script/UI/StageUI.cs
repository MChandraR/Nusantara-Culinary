using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StageUI : MonoBehaviour
{
    GameObject mainCamera;
    public GameObject judul;
    public GameObject deskripsi;
    public GameObject daftarmenu;
    public Canvas detailStageUI;

    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    }

    void Update()
    {
        if (mainCamera != null)
        {
            this.transform.rotation = new Quaternion(mainCamera.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z, 0.75f);
        }
    }

    public void showDetailStage(StageModel model)
    {
        string menu = "";
        judul.GetComponent<TextMeshProUGUI>().text = model.nama_kota;
        deskripsi.GetComponent<TextMeshProUGUI>().text = model.deskripsi;
        for (int i=0;i<model.menu.Length;i++)
        {
            menu +=   (i+1).ToString() + "." + model.menu[i] + "\n";
        }
        daftarmenu.GetComponent<TextMeshProUGUI>().text = menu;

        detailStageUI.enabled = true;
    }

    public void  startGame()
    {
        Debug.Log("Start the game");
    }
}
