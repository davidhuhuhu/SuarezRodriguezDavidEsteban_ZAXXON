using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bulletcol : MonoBehaviour
{
    //public int scoreValue;
    public bool impact;
    //Rigidbody rb;
    public static Bulletcol THIS;
    
    private void Awake()
    {
        THIS = this;
        //scoreValue = 0;
        //rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Meteoritos")
        {
            GameManager.THIS.puntos++;
            GameObject.Find("Canvas").GetComponent<HudUpdate>().UpdatePoints();
            /*
           //scoreValue++;
            impact = true;
            GameObject.Find("Manager").GetComponent<score>().AddScore();
            //score.THIS.AddScore();
            */
        }
        
    }


  
}
