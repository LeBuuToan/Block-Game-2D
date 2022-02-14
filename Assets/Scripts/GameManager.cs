using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	public GameObject pauseMenuUI;

	public bool paused = false;

    void Awake()
    {
        instance = GetComponent<GameManager>();
    }

    public void ResumeButton()
    {
        paused = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PauseButton()
    {
        paused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;

    }

    public void ReplayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
