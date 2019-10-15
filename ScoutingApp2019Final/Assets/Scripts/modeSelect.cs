using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class modeSelect : MonoBehaviour
{
    public Button startButton;
    public Dropdown mode;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("role"))
        {
            SceneManager.LoadScene("MainMenu");
        }
        startButton.onClick.AddListener(setMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setMode()
    {
        if (mode.value == 0)
            PlayerPrefs.SetString("role", "Scouting");
        if (mode.value == 1)
            PlayerPrefs.SetString("role", "Fouls");
        if (mode.value == 2)
            PlayerPrefs.SetString("role", "Defense");
        if (mode.value == 3)
            PlayerPrefs.SetString("role", "Strategy");
        if (mode.value == 4)
            PlayerPrefs.SetString("role", "Assistant");
        SceneManager.LoadScene("MainMenu");
    }
}
