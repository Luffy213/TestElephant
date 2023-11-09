using UnityEngine.SceneManagement;
using UnityEngine;

public class Scene_controller: MonoBehaviour
{
    public void GoToNextScene()
    {
        SceneManager.LoadScene(1);
    } 
    public void GoToPrevScene()
    {
        SceneManager.LoadScene(0);
    }
}
