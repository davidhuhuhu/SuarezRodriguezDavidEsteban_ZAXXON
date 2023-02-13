using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public static CharacterSelection THIS;
    public GameObject[] naves;
    public GameObject[] navesPrefabImage;
    Image naveSprite;
    public int navesleccionada;

    //Array con las imágenes de naves seleccionadas
    [SerializeField] Sprite[] navesSprites;
    [SerializeField] Image naveImage;
    
    public TMP_Text txtnave;
    public void Start()
    {
        THIS = this;
        //naves[0].SetActive(true);
        // navesPrefabImage[0].SetActive(true);

        //Le pongo la primare imagen
        if(PlayerPrefs.HasKey("navesleccionada"))
        {
            navesleccionada = PlayerPrefs.GetInt("navesleccionada");
        }
        else
        {
            navesleccionada = 0;
        }

            
        GameManager.naveSelecionada = navesleccionada;
        naveImage.sprite = navesSprites[navesleccionada];



    }
    private void Update()
    {
        GameObject prefab = naves[navesleccionada];
        
        txtnave.text = prefab.name;
        
        
        
    }

    public void NextNave()
    {
        
        
        navesleccionada++;
        if(navesleccionada == navesSprites.Length)
        {
            navesleccionada = 0;
        }
        naveImage.sprite = navesSprites[navesleccionada];
        GameManager.naveSelecionada = navesleccionada;
        PlayerPrefs.SetInt("navesleccionada", navesleccionada);
        /*
        naves[navesleccionada].SetActive(false);
        navesPrefabImage[navesleccionada].SetActive(false);
        navesleccionada = (navesleccionada + 1) % naves.Length;
        navesleccionada = (navesleccionada + 1) % navesPrefabImage.Length;
        naves[navesleccionada].SetActive(true);
        navesPrefabImage[navesleccionada].SetActive(true);
        */
    }
    public void PreviousNave()
    {
        print("anterior");
        if (navesleccionada == 0)
        {
            navesleccionada = navesSprites.Length;
        }
        navesleccionada--;
        
        naveImage.sprite = navesSprites[navesleccionada];
        GameManager.naveSelecionada = navesleccionada;
        PlayerPrefs.SetInt("navesleccionada", navesleccionada);
        /*
        naves[navesleccionada].SetActive(false);
        navesPrefabImage[navesleccionada].SetActive(false);
        navesleccionada--;
        if(navesleccionada<0)
        {
            navesleccionada += naves.Length;
            navesleccionada += navesPrefabImage.Length;
        }
        naves[navesleccionada].SetActive(true);
        navesPrefabImage[navesleccionada].SetActive(true);
        */

    }

    public void StartGame()
    {

        PlayerPrefs.SetInt("navesleccionada", navesleccionada);
        naves[navesleccionada].SetActive(true);
        SceneManager.LoadScene(2, LoadSceneMode.Single);

        
    }



}
