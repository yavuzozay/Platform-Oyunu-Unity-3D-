using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultSc : MonoBehaviour
{
    int score=0;
    [SerializeField] Text yourScore;
    
    private void Awake()
    {
        score = PlayerPrefs.GetInt("score");

    }

    void Update()
    {
        yourScore.text = "Score : " + score.ToString();
        Debug.Log(score);
    }
}
