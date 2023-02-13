using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{

    float speed;
    [SerializeField] NaveMovement naveMovement;
    GameObject navesita;
    public GameObject destruccion;

    // Start is called before the first frame update
    void Start()
    {
        navesita = GameObject.FindWithTag("spaceShip");
        naveMovement = navesita.GetComponent<NaveMovement>();
        speed = naveMovement.shipSpeed;

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.tag =="PowerVup")
        {

            speed = speed*2;

        }
   
        transform.Translate(Vector3.back * Time.deltaTime * speed);


        Destruir();
  
               
    }
    
    void Destruir ()
    {
        //gameObject en minuscula se refiere a su propia instancia
        


        if (transform.position.z < -10f)
        {

            Destroy(gameObject);


        }


    }
    private void OnTriggerEnter(Collider other)
    {
       if( other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Instantiate(destruccion, transform.position, transform.rotation);
        }
    }

}


