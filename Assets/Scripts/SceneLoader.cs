using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    //private Button _startButton;

    //public void Awake()
    //{
    //    _startButton = GameObject.Find("StartButton").GetComponent<Button>();
    //    _startButton.onClick.AddListener(StartButtonClicked);
    //}

    //public void OnDestroy()
    //{
    //    _startButton.onClick.RemoveAllListeners();
    // }

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
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
