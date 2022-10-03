using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{

    float speed;
    [SerializeField] NaveMovement naveMovement;
    GameObject navesita;

    // Start is called before the first frame update
    void Start()
    {
        navesita = GameObject.Find("Navesitag");
        naveMovement = navesita.GetComponent<NaveMovement>();

        

    }

    // Update is called once per frame
    void Update()
    {

        speed = naveMovement.speed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);


        Destruir();
          
   
               
    }
    
    void Destruir ()
    {
        //gameObject en minuscula se refiere a su propia instancia
        


        if (transform.position.z < -5f)
        {

            Destroy(gameObject);


        }


    }

}


