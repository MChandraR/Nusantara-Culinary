using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StageDataModel
{
    public Kota[] kota; 

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

}
