using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CoinSc : MonoBehaviour,IOdulOzellikleri
{
    public bool etkilesim;
    [SerializeField] int deger;
     GameObject player;
    float konumZ;


    ScoreManager sm;
    private void Awake()
    {
        konumZ = gameObject.transform.position.z;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Start()
    {
        
    }
     void Update()
    {
        if (etkilesim)
            transform.position += new Vector3(0,0.025f,0.045f);

        float zDist = (player.transform.position.z-konumZ);
        if (zDist > 2)
            Destroy(gameObject);
       
    }

 

    public void PuanArttir()
    {
        ScoreManager.score +=deger;
       
       
    }
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            etkilesim = true;
            PuanArttir();
            Destroy(gameObject,.3f);

        }
    }

    
}
