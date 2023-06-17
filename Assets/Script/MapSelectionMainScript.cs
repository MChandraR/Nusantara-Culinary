using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelectionMainScript : MonoBehaviour
{

    public TextAsset jsonFile;

    void Start()
    {
        stageData employeesInJson = JsonUtility.FromJson<stageData>(jsonFile.text);

        Debug.Log(employeesInJson.kota[0].nama_kota);
    }

    void Update()
    {
        
    }

}


[System.Serializable]
public class stageData
{
    public Kota[] kota;
}

[System.Serializable]
public class Kota
{
    public string nama_kota;
    public string[] recipe;

    public string getNamaKota()
    {
        return nama_kota;
    }

    public string getRecipe(int index)
    {
        return index < recipe.Length ? recipe[index] : "";
    }
}


