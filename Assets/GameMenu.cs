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
        
    }
    
    

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
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
