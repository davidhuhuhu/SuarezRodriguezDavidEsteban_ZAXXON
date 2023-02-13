using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elinstanciadordeobjetos : MonoBehaviour
{

    [SerializeField] NaveMovement naveMovement;
    [SerializeField] GameObject[] obstacle;
    [SerializeField] GameObject[] navesitas;
    float intervalo;
    public float speed;
    float distanciaEntreColumnas;
    float iniPosInt;


    // Start is called before the first frame update
    void Start()
    {
        
        iniPosInt = 40f;
        intervalo = 3f;
        distanciaEntreColumnas = 12f;
        speed = 60f;
        //CrearColumna(transform.position.z);

        StartCoroutine("Corrutina");

        CrearObstIntermedios();
    }

    void CrearObstIntermedios()
    {
        
        float distanciaTotal = transform.position.z - iniPosInt;
        float nObstInt = Mathf.Floor(distanciaTotal / distanciaEntreColumnas);

        
        
        
        //+= es para sumarle un valor a una variable
        for (int n = 0; n< nObstInt; n++)
        {

            
            CrearColumna(iniPosInt);
            iniPosInt += distanciaEntreColumnas;
        }


    }


    // Update is called once per frame
   
    void CrearColumna(float posZ)
    {

        // El float posZ es para darle al metodo un logar donde ejecutarse, si no se le llama da error al llamar al metodo
        //en vector 3 instpos el posZ ha sustituido a transform.position.z
        // ( el inicio esta en 0, lo que se tiene que dar, si se da es la tercera)


            float randomX = Random.Range(-70f, 70f);
            float randomY = Random.Range(-70f, 70f);
            //Vector3 instposY =new Vector3(randomX, randomY, posZ);
            Vector3 instposX= new Vector3(randomX, randomY, posZ);
        //sin rotacion
            int random = Random.Range(0,obstacle.Length);            

        //GameObject cloneY = Instantiate(obstacle[random], instposY, Quaternion.identity);
        GameObject cloneX = Instantiate(obstacle[random], instposX, Quaternion.identity);
        //GameObject PowerVelocityUp = Instantiate(obstacle[5], instposX, Quaternion.identity);
        

        //cloneY.gameObject.tag = "Meteoritos";
        //cloneX.gameObject.tag = "Meteoritos";
        //PowerVelocityUp.gameObject.tag = "PowerVUp";









    }

    
    
    IEnumerator Corrutina()
    {

      while(true)
        {
            // aqui se debe llamar al transform.position.z para que empieze en z y no en la variable de posZ

            if (GameManager.alive == true)
            {
                
                CrearColumna(transform.position.z);

            }
            else
            {
                StopCoroutine("Corrutina");
            }    
              
           /* if(naveMovement.shipSpeed > 0 )
            {
                

            }*/

           // speed = naveMovement.shipSpeed;

            intervalo = distanciaEntreColumnas / speed;
                                   
             yield return new WaitForSeconds(intervalo);

        }

        




    }
}
