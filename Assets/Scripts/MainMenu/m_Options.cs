using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class m_Options : MonoBehaviour {



    public bool fullscreen = true;


    public void LoadDemo()
    {
        SceneManager.LoadScene(1);
    }

    public void RES_1610_1920x1200()
    {
        Screen.SetResolution(1920, 1200, fullscreen);
    }

    public void RES_1610_1680x1050()
    {
        Screen.SetResolution(1680, 1050, fullscreen);
    }

    public void RES_1610_1440x900()
    {
        Screen.SetResolution(1440, 900, fullscreen);
    }

    public void RES_1610_1280x800()
    {
        Screen.SetResolution(1280, 800, fullscreen);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
