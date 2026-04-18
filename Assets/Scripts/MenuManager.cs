using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] string gameScene;

    public void Quit()
    {
        Application.Quit();
    }

    public void GotoPlayScene()
    {
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
    }
}


