using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSc : MonoBehaviour,IOdulOzellikleri
{
    public bool etkilesim;
    public int deger;

    ScoreManager sm;

    private void Start()
    {
    }
    private void Update()
    {
        
    }
   
    public void PuanArttir()
    {
        ScoreManager.score += 5;
       
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            etkilesim = true;
            PuanArttir();
            Destroy(gameObject, 1f);

        }
    }
}
