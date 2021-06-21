using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
     float sure=0 ;
    int time;
    int temp=0;
    [SerializeField] Text timeText;
    
    void Start()
    {
       
    }

    void Update()
    {
            sure += Time.deltaTime;
             time = (int)sure;
        if(time-temp>=1)
        {
            ScoreManager.score ++;
            temp = time;
            

        }

        timeText.text = "Time :" + time.ToString();

        
    }
}
