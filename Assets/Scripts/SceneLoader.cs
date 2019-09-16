using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    //cached reference
    GameStatus gameStatus;

    public void StartButtonClicked()
    {
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().ResetGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
