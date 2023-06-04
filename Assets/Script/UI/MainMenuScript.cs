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
        SavedDataModel saveData = JsonUtility.FromJson<SavedDataModel>(saveFile.text);
        Debug.Log(saveData.getProgress());
    }

}
