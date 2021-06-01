using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    [SerializeField] float sure ;
    [SerializeField] Text timeText;
    private bool gameActive;
    void Start()
    {
        gameActive = true;
    }

    void Update()
    {
        if (gameActive)
        {
            sure -= Time.deltaTime;
            timeText.text = "Time :" + ((int)sure).ToString();
        }
        if (sure < 0)
            gameActive = false;
      
        
        
    }
}
