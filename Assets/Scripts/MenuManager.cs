using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] string gameScene;
    [SerializeField] GameObject[] differentScreens;

    public void Quit()
    {
        Application.Quit();
    }

    public void SwitchScreen(int screenIndex)
    {
        foreach(GameObject currScreen in differentScreens)
        {
            currScreen.SetActive(false);
        }
        differentScreens[screenIndex].SetActive(true);
    }

    public void GotoPlayScene()
    {
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
    }
}


