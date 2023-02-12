using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager THIS;
   

    // Start is called before the first frame update
    public static bool alive;

    public int lifes;

    public int puntos;
    public float Velocity;
    
    [SerializeField] GameObject naveMalla;

    //Nave elegida por el usuario
    //public int naveElegida;
   

    public void Awake()
    {

        THIS = this;

        


        
    }

    private void Start()
    {

        StartGame();
        naveMalla = GameObject.FindGameObjectWithTag("spaceShip");

    }

    public void StartGame()
    {

        alive = true;
        

    }


    private void Update()
    {


        Velocity = naveMalla.GetComponent<NaveMovement>().shipSpeed;



    }



}
