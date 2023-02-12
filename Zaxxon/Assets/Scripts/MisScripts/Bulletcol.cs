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
    NaveMovement NaveM;
    public float naveSpeed;
    
    private void Awake()
    {
        THIS = this;
        //scoreValue = 0;
        //rb = GetComponent<Rigidbody>();
        
    }
    private void Start()
    {
        
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
        else if(other.gameObject.tag == "PowerVUp")
        {
            GameManager.THIS.Velocity++;
            GameObject.Find("Canvas").GetComponent<HudUpdate>().UpdateSpeed();
        }

        
    }


  
}
