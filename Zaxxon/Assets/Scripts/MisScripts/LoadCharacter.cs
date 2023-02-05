using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{

    public GameObject[] NavesPrefab;
    public Transform SpawnPoint;
    public TMP_Text label;
    
    void Start()
    {
     
        
    
        int navesleccionada = PlayerPrefs.GetInt("navesleccionada");
        GameObject prefab = NavesPrefab[navesleccionada];
        GameObject clone = Instantiate(prefab, SpawnPoint.position, Quaternion.identity);
        label.text = prefab.name ;
        
        clone.gameObject.tag = "spaceShip";
        
    }

   
}
