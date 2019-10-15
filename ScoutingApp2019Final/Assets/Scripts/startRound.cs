using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startRound : MonoBehaviour
{
    public Toggle t1, t2, t3, t4, t5, t6, tR, sp1, sp2, sp3, sp4, sp5;
    public Button startRoundButton, noShowButton;

    // Use this for initialization
    void Start()
    {
        startRoundButton.onClick.AddListener(loadNextScene);
        noShowButton.onClick.AddListener(loadNoShowVerificationScene);
    }

    void Update()
    {
    }

    void loadNoShowVerificationScene()
    {
        SceneManager.LoadScene("NoShowVerification");
    }

    void loadNextScene()
    {
        if (sp1.isOn || sp2.isOn || sp3.isOn || sp4.isOn || sp5.isOn)
        {
            setStartingPosition();
            setPreLoadPositions();
            SceneManager.LoadScene(Variables.sceneIdentifier() + "datacollection");
        }
    }

    void setStartingPosition()
    {
        if (sp1.isOn)
            Variables.startingPosition = 0;
        else if (sp2.isOn)
            Variables.startingPosition = 1;
        else if (sp3.isOn)
            Variables.startingPosition = 2;
        else if (sp4.isOn)
            Variables.startingPosition = 3;
        else if (sp5.isOn)
            Variables.startingPosition = 4;
        Variables.preload = Variables.preload + Variables.ToBinary(Variables.startingPosition, 3);
    }

    void setPreLoadPositions()
    {
        if (tR.isOn)
        {
            Variables.preload = Variables.preload + "1";
        }
        else
        {
            Variables.preload = Variables.preload + "0";
        }
        if (t1.isOn)
        {
            Variables.preload = Variables.preload + "1";
        }
        else
        {
            Variables.preload = Variables.preload + "0";
        }
        if (t2.isOn)
        {
            Variables.preload = Variables.preload + "1";
        }
        else
        {
            Variables.preload = Variables.preload + "0";
        }
        if (t3.isOn)
        {
            Variables.preload = Variables.preload + "1";
        }
        else
        {
            Variables.preload = Variables.preload + "0";
        }
        if (t4.isOn)
        {
            Variables.preload = Variables.preload + "1";
        }
        else
        {
            Variables.preload = Variables.preload + "0";
        }
        if (t5.isOn)
        {
            Variables.preload = Variables.preload + "1";
        }
        else
        {
            Variables.preload = Variables.preload + "0";
        }
        if (t6.isOn)
        {
            Variables.preload = Variables.preload + "1";
        }
        else
        {
            Variables.preload = Variables.preload + "0";
        }
    }
}
