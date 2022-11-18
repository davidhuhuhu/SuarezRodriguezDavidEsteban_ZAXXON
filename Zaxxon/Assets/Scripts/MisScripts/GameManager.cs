using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager THIS;
   

    // Start is called before the first frame update
    public static bool alive;

    public int lifes;

    //Nave elegida por el usuario
    //public int naveElegida;
   

    public void Awake()
    {

        THIS = this;



    }

    private void Start()
    {

        StartGame();
        
    }

    public void StartGame()
    {

        alive = true;
        

    }


    private void Update()
    {
        




    }



}
