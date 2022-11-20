using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PauseScript : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject PauseUI;
    public static bool isPaused;
    void Start()
    {
        isPaused = false;
        PauseUI.SetActive(false);
        MainUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }

    public void resumeGame()
    {
        isPaused = false;
        PauseUI.SetActive(false);
        MainUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
    public void pauseGame()
    {
        isPaused = true;
        PauseUI.SetActive(true);
        MainUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }

    public void exitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
