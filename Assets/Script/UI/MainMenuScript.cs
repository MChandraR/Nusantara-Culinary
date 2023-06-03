using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public TextAsset saveFile;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void playGame()
    {
        Debug.Log("Scene telah berhasil di load");
        SceneManager.LoadScene("MainScene");
        loadSavedGame();
    }

    public void loadSavedGame()
    {
        SavedData saveData = JsonUtility.FromJson<SavedData>(saveFile.text);
        Debug.Log(saveData.getProgress());
    }

    class SavedData
    {
        public string date, progress;
        public string getDate()
        {
            return date;
        }

        public string getProgress()
        {
            return progress;
        }
    }
}
