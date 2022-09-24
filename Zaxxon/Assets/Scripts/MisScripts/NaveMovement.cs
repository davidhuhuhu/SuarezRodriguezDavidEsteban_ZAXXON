using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovement : MonoBehaviour
{
    //Movimiento de la nave

    Vector3 NaveInitPos = Vector3.zero;
    Vector3 NaveMov;
    [SerializeField] GameObject Minave;

    //Variables de posicion y movimiento

    [SerializeField] float movY;
    [SerializeField] float movX;
    [SerializeField] float posY;
    [SerializeField] float posX;

    //Variables de velocidad

    [SerializeField] float movSpeed;




    void Start()
    {

        movSpeed = 15f;

        transform.position = NaveMov;
        



    }

    // Update is called once per frame
    void Update()
    {

       
        if (Input.GetKey(KeyCode.Joystick1Button8))
                {
           
            transform.position += new Vector3(0f, 1f, 0f);

        }

    }
    void MovimientoNave()
    {



    }
}
