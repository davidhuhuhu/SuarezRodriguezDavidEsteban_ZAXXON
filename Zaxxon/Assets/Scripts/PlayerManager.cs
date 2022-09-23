using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //posicion de la nave al inicio

    Vector3 navePos = Vector3.zero;
    /*Vector3 despl = new Vector3(0f, 1f, 0f);*/


    //Velocidad de movimiento

    [SerializeField] float desplSpeed;

    //variables de input

    float moveY;
    float moveX;
    float rightjoystick;

    float posY;
    float posX;
 



    // Start is called before the first frame update
    void Start()
    {

        desplSpeed = 5f;

        //comienza en 0 de rotacion

        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        transform.position = navePos; 
    }

    // Update is called once per frame
    void Update()

    {
        //Obtengo mi posicion en X y en Y

        posY = transform.position.y;
        posX = transform.position.x;
                    
        
        //Translacion valores gamepad

        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        

        //rotacion gamepad

        rightjoystick = Input.GetAxis("HorizontalRJ");

        print(moveY);
        print(moveX);
        /* navePos +=  despl;
         transform.position = navePos * deplSpeed * Time.deltaTime;*/

        Vector3 movimientoV = Vector3.up * desplSpeed * Time.deltaTime * moveY;
        Vector3 movimientoH = Vector3.right * desplSpeed * Time.deltaTime * moveX;

        //transform.Translate(movimientoV, Space.World);
        //transform.Translate(movimientoH, Space.World);

         //|| A no ser
        if((posY <= 10 || moveY < 0)&&(posY >=0|| moveY >0))
        {

            transform.Translate(movimientoV, Space.World);
        } 

        if(posX <= 0 || moveX < 0)
        {

            transform.Translate(movimientoH, Space.World);
        }


        transform.Rotate(Vector3.forward * Time.deltaTime * -360f * rightjoystick);
        

        /*transform.eulerAngles = new Vector3(0f, 0f, moveX * -60f);*/










    }
}
