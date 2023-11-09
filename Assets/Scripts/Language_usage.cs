using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Language_usage : MonoBehaviour
{
    public int language;
    
    void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
    }

    public void RussianLanguage()
    {
        language = 0;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene(0);
    }

    public void EnglishLanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("language", language);
        SceneManager.LoadScene(0);
    }


}
