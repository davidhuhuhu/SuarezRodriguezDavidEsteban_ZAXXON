using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudUpdate : MonoBehaviour
{


    [SerializeField] Image lifesImage;

    [SerializeField] Sprite[] lifesArray;
   public static HudUpdate THIS ;

    [SerializeField] Text scoreText;
    [SerializeField] Text NaveVelocity;

    
    // Start is called before the first frame update
    void Start()
    {
        THIS = this;
        GameManager.THIS.lifes = 3;
        lifesImage.sprite = lifesArray[GameManager.THIS.lifes];
        
    }

    

    public void UpdateLifes()
    {
        int y = GameManager.THIS.lifes;
        lifesImage.sprite = lifesArray[y];

    }

    public void UpdatePoints()
    {
        scoreText.text = "Score:" + GameManager.THIS.puntos; ;
        //print(scoreValor);
        
    }
    public void UpdateSpeed()
    {
        NaveVelocity.text = "Speed" + GameManager.THIS.Velocity;
    }
}
