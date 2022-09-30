using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elinstanciadordeobjetos : MonoBehaviour
{


    [SerializeField] GameObject obstacle;
    
    
    // Start is called before the first frame update
    void Start()
    {




        CrearColumna();

        StartCoroutine("Corrutina");


    }

    // Update is called once per frame
    void Update()
    {


        



    }
    void CrearColumna()
    {

        
        // ( el inicio esta en 0, lo que se tiene que dar, si se da es la tercera)
       
            float randomX = Random.Range(-15f, 15f);
            Vector3 instpos = new Vector3(randomX, 0f, transform.position.z);
            //sin rotacion
            Instantiate(obstacle, instpos, Quaternion.identity);
                    


    }

    IEnumerator Corrutina()
    {

      while(true)
        {

            CrearColumna();


            yield return new WaitForSeconds(1f);



        }


    }
}
