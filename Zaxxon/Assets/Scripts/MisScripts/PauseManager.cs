using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    
    InputActions inputActions;
    public GameObject PanelSettings;
    [SerializeField] Button resume;
    bool paused=false ;
   
   

    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Control.Pause.started += _ => PauseGame();
      

    }

    private void Start()
    {
        //pauseManager = this;

        PanelSettings.SetActive(false);
        
    }

   
    public void PauseGame()
    {

        
        if (paused)
        {
            Time.timeScale = 1;
            PanelSettings.SetActive(false);
            paused = false;            
            resume.Select();

        }
        else
        {
            Time.timeScale = 0;
            PanelSettings.SetActive(true);
            paused = true;
                        
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
