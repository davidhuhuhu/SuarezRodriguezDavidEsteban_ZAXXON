using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelection : MonoBehaviour
{
    public static CharacterSelection THIS;
    public GameObject[] naves;
    public int navesleccionada = 0;
    public TMP_Text txtnave;
    public void Start()
    {
        THIS = this;
        
        
    }
    private void Update()
    {
        GameObject prefab = naves[navesleccionada];
        txtnave.text = prefab.name;
    }

    public void NextNave()
    {
        naves[navesleccionada].SetActive(false);
        navesleccionada = (navesleccionada + 1) % naves.Length;
        naves[navesleccionada].SetActive(true);

    }
    public void PreviousNave()
    {

        naves[navesleccionada].SetActive(false);
        navesleccionada--;
        if(navesleccionada<0)
        {
            navesleccionada += naves.Length;
        }
        naves[navesleccionada].SetActive(true);


    }

    public void StartGame()
    {

        PlayerPrefs.SetInt("navesleccionada", navesleccionada);
        SceneManager.LoadScene(2, LoadSceneMode.Single);

        
    }



}
