using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public TextAsset saveFile;

    // UNITY BUILD-IN METHOD
    void Start()
    {
        
    }
    
    // METHOD
    public void playGame()
    {
        Debug.Log("Play");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        loadSavedGame();
    }

    public void settingGame()
    {
        Debug.Log("Settings");
    }

    public void exitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void loadSavedGame()
    {
        SavedData saveData = JsonUtility.FromJson<SavedData>(saveFile.text);
        Debug.Log(saveData.getProgress());
    }

    // CLASS
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
