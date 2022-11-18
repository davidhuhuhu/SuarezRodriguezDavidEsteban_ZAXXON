using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    
    public static int scoreValor;
    public Text scoreText;
    public static score THIS;
    public int scorePublic;
    
   

    private void Awake()
    {
        THIS = this;
        
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
      
    }

    private void Update()
    {
        
        scorePublic = scoreValor;
    }
    public void AddScore()
    {
        if(Bulletcol.THIS.impact==true)
        {
            scoreValor++;
            scoreText.text = "Score:" + scoreValor;
            print(scoreValor);
        }
        
        
    }




}
