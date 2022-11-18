using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPanel : MonoBehaviour
{
    public GameObject deadPanelText;
    public static DeadPanel deadPanel;

    // Start is called before the first frame update
    void Start()
    {
        deadPanel = this;
        deadPanelText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void show()
    {
        
        deadPanelText.SetActive(true);


    }
}
