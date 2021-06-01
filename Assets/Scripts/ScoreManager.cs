using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    [SerializeField] Text scoreText;
    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text="Score :"+score.ToString();
    }
}
