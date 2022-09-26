using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //Booleana que me dice si estoy vivo
    bool alive = true;


    //Posición de la nave al inicio
    Vector3 navePos = Vector3.zero;

    //Velocidad de desplazamientio
    [SerializeField] float desplSpeed;

    //Variables de Input
    float moveY;
    float moveX;

    float rightStickH;

    //Restricción de movimiento
    float posY;
    float posX;
    float limiteVertUp = 10f;
    float limiteVertDown = 0f;
    float limiteHorRight = 10f;
    float limiteHorLeft = -10f;

    bool inLimitV = true;
    bool inLimitH = true;



    //bool inLimitY = true;


    // Start is called before the first frame update
   
    void Start()
    {

        desplSpeed = 15f;

        //comienza en 0 de rotacion

        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        transform.position = navePos; 
    }

    // Update is called once per frame
    void Update()

    {
       // Si hay un IF sin corchetes solo ejecutara la primera linea, como aqui abajo con movernave
        if (alive)
            MoverNave();



    }
    void MoverNave()
    {
        /* //Obtengo mi posicion en X y en Y

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

        //Variables Vector3 para movimientos de translacion y rotacion

        /* Vector3 movimientoV = Vector3.up * desplSpeed * Time.deltaTime * moveY;
         Vector3 movimientoH = Vector3.right * desplSpeed * Time.deltaTime * moveX;
         Vector3 Rotacion = Vector3.forward * Time.deltaTime * -360f * rightjoystick;


         if (InLimitV)
             MoverNave();


         //transform.Translate(movimientoV, Space.World);
         //transform.Translate(movimientoH, Space.World);


         //Movimiento con limite
         //significa || A no ser u 'o' ctrl+alt+1
         //significa && se deben cumplir, si el primero no se cumple, el siguiente jamás se cumplirá AND
         if ((posY <= 30 || moveY < 0) && (posY >= 0 || moveY > 0))
         {

             transform.Translate(movimientoV, Space.World);
         }

         if ((posX <= 60 || moveX < 0) && (posX >= -60 || moveX > 0))
         {

             transform.Translate(movimientoH, Space.World);
         }



         transform.Rotate(Rotacion);


         /*transform.eulerAngles = new Vector3(0f, 0f, moveX * -60f);*/

        //Obtengo mi posición en X y en Y
        posY = transform.position.y;
        posX = transform.position.x;

        //Obtengo los valores del Gamepad
        moveY = Input.GetAxis("Vertical");
        moveX = Input.GetAxis("Horizontal");
        //Rotación 
        rightStickH = Input.GetAxis("HorizontalJ2");
        //print(rightStickH);

        //print(moveY);



        Vector3 movimientoVertical = Vector3.up * desplSpeed * Time.deltaTime * moveY;
        Vector3 movimientoHorizontal = Vector3.right * desplSpeed * Time.deltaTime * moveX;

        if (inLimitV)
            transform.Translate(movimientoVertical, Space.World);

        if (inLimitH)
            transform.Translate(movimientoHorizontal, Space.World);


        transform.Rotate(Vector3.forward * Time.deltaTime * -360f * rightStickH);

        //transform.eulerAngles = new Vector3(0f, 0f, moveX * -60f);

    }

    void CheckLimits()
    {

        //Compruebo límites verticales
        if (posY > limiteVertUp && moveY > 0)
        {
            inLimitV = false;
        }
        else if (posY < limiteVertDown && moveY < 0)
        {
            inLimitV = false;
        }
        else
        {
            inLimitV = true;
        }

        //Compruebo límites horizontales
        if (posX > limiteHorRight && moveX > 0)
        {
            inLimitH = false;
        }
        else if (posX < limiteHorLeft && moveX < 0)
        {
            inLimitH = false;
        }
        else
        {
            inLimitH = true;
        }





    }
}


