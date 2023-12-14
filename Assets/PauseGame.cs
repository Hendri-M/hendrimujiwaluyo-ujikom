using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject _pauseGame;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _pauseGame.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
        _pauseGame.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Retry()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
