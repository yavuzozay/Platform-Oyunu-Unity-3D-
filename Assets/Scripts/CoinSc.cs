using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSc : MonoBehaviour,IOdulOzellikleri
{
    public bool etkilesim;
    public int deger;
    Animation animation;

    ScoreManager sm;

     void Start()
    {
        animation = GetComponent<Animation>();
    }
     void Update()
    {
        if (etkilesim)
            transform.position += new Vector3(0,0.01f,0.01f);
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
            Destroy(gameObject, .3f);

        }
    }

    
}
