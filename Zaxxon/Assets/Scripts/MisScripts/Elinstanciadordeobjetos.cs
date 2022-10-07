using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elinstanciadordeobjetos : MonoBehaviour
{

    [SerializeField] NaveMovement naveMovement;
    [SerializeField] GameObject obstacle;
    float intervalo;
    float speed;
    float distanciaEntreColumnas;

    GameObject navesita;
    
    // Start is called before the first frame update
    void Start()
    {

        intervalo = 1f;

        //navesita = GameObject.Find("Navesitag");
        //naveMovement = navesita.GetComponent<NaveMovement>();
        distanciaEntreColumnas = 13f;     

        CrearColumna(transform.position.z);

        StartCoroutine("Corrutina");


    }

    void CrearObstIntermedios()
    {

        

        float nObstInt = Mathf.Floor(80 / distanciaEntreColumnas);

        
        float iniPosInt = 20f;
        
        //+= es para sumarle un valor a una variable
        for (int n = 0; n< nObstInt; n++)
        {


            print(n);
            CrearColumna(iniPosInt);
            iniPosInt += distanciaEntreColumnas;


        }



    }


    // Update is called once per frame
    void Update()
    {


        



    }
    void CrearColumna(float posZ)
    {

        // El float posZ es para darle al metodo un logar donde ejecutarse, si no se le llama da error al llamar al metodo
        //en vector 3 instpos el posZ ha sustituido a transform.position.z
        // ( el inicio esta en 0, lo que se tiene que dar, si se da es la tercera)
        
       
            float randomX = Random.Range(-30f, 30f);
            Vector3 instpos = new Vector3(randomX, 0f, posZ);
            //sin rotacion
            Instantiate(obstacle, instpos, Quaternion.identity);
                    



    }

    
    
    IEnumerator Corrutina()
    {

      while(true)
        {
            // aqui se debe llamar al transform.position.z para que empieze en z y no en la variable de posZ

            speed = naveMovement.speed;
            intervalo = distanciaEntreColumnas / naveMovement.speed;
            print(intervalo);

            CrearColumna(transform.position.z);
            
            yield return new WaitForSeconds(intervalo);

        }

        




    }
}
