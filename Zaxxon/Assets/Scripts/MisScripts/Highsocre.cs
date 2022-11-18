using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highsocre : MonoBehaviour
{
    InputActions inputActions;
    public GameObject PanelSettings;
    [SerializeField] Button resume;
    bool highS = false;



    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Control.Highscore.started += _ => highScore();


    }

    private void Start()
    {
        //pauseManager = this;

        PanelSettings.SetActive(false);

    }


    public void highScore()
    {


        if (highS)
        {
            Time.timeScale = 1;
            PanelSettings.SetActive(false);
            highS = false;
            resume.Select();

        }
        else
        {
            Time.timeScale = 0;
            PanelSettings.SetActive(true);
            highS = true;

        }




    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
