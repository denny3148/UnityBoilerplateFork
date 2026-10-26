using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
