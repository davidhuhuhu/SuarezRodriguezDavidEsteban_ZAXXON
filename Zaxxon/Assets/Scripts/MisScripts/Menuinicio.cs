using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuinicio : MonoBehaviour
{
    // Start is called before the first frame update

    public void EmpezarEscena()
    {
        SceneManager.LoadScene(1);

    }
    public void EmpezarNivel1()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;

    }

    public void CharactSelect()
    {
        SceneManager.LoadScene(1);


    }

    public void CargarEscena()
    {
        GameManager.alive = true;
        //SceneManager.LoadScene(1);
        Time.timeScale = 1;
        

    }
    public void SalirJuego()
    {
        
        Application.Quit();

    }
    public void MenuInicio()
    {

        SceneManager.LoadScene("Inicio");
    }
    
}
