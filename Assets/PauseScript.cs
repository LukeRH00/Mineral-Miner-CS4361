using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PauseScript : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject PauseUI;
    public GameObject StoreUI;
    public static bool isPaused;
    void Start()
    {
        isPaused = false;
        PauseUI.SetActive(false);
        StoreUI.SetActive(false);
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
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (StoreUI.activeSelf)
            {
                resumeGame();
            }
            else
            {
                storeMenu();
            }
        }
    }

    public void resumeGame()
    {
        isPaused = false;
        PauseUI.SetActive(false);
        StoreUI.SetActive(false);
        MainUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
    public void pauseGame()
    {
        isPaused = true;
        PauseUI.SetActive(true);
        StoreUI.SetActive(false);
        MainUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }

    public void storeMenu()
    {
        isPaused = true;
        PauseUI.SetActive(false);
        StoreUI.SetActive(true);
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
