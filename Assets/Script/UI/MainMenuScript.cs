using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public TextAsset saveFile;
    public GameObject mainCamera;
    public AudioSource SFXSource;
    public AudioClip audioClip;
    public GameObject settingsCanvas;

    // UNITY BUILD-IN METHOD
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").gameObject;
        if (mainCamera.GetComponents<AudioSource>()[1] != null)
        {
            SFXSource = mainCamera.GetComponents<AudioSource>()[1];
        }
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

    public void PlayBtnSFX()
    {
        if (SFXSource != null)
        {
            SFXSource.Play();
        }
    }

    public void test()
    {
        Debug.Log("Test");
    }

}
