using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initgame : MonoBehaviour
{


    [SerializeField] GameObject navePrefab;
    
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(navePrefab);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
