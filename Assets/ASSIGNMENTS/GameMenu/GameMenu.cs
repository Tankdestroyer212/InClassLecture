using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject creditsMenu;
    public GameObject quitPopup;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        DisableAll();
        mainMenu.SetActive(true);
    }

    public void ShowOptionsMenu()
    {
        DisableAll();
        optionsMenu.SetActive(true);
    }

    public void ShowCreditsMenu()
    {
        DisableAll();
        creditsMenu.SetActive(true);
    }

    public void ShowQuitPopup()
    {
        quitPopup.SetActive(true);
    }

    public void CloseQuitPopup()
    {
        quitPopup.SetActive(false);
    }

    public void DisableAll()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
        quitPopup.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
