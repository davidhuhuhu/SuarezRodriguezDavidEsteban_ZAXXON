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
    [SerializeField] float JSLeft;
    

    //Variables de velocidad

    [SerializeField] float movSpeed;




    void Start()
    {
        
        movSpeed = 40f;
        
        transform.position = NaveMov;
        transform.rotation = Quaternion.Euler (0f,0f,0f);
        



    }

    // Update is called once per frame
    void Update()
    {

        Vector3 Vuelo = new Vector3(0, Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * movSpeed * Time.deltaTime;
        Vector3 Rotate = new Vector3(Input.GetAxis("HorizontalRJ"), 0, 0) *-360 * Time.deltaTime;

        if (posX <= 50 )
        {

          transform.Translate(Vuelo);
          transform.Rotate(Rotate);


        }


        



    }
    void MovimientoNave()
    {



    }
}
