using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelSelectPanel;
    public void startButtonClick()
    {
        menuPanel.SetActive(false);
        levelSelectPanel.SetActive(true);

    }

    public void stopButtonClick()
    {
        Application.Quit();
    }

    public void level1ButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
