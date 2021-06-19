using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject coin5pt;
    public GameObject coin10pt;
    public GameObject gem;
     public GameObject playerObj;


    public GameObject sonKonum;
   Vector3 addRandomPos;


    private void Awake()
    {
        Generate();
        Instantiate(gem, playerObj.transform.position + Vector3.forward, gem.transform.rotation);
        



    }
    public void Generate()
    {
       

        sonKonum = Instantiate(sonKonum, sonKonum.transform.position + Vector3.forward*4.7f,sonKonum.transform.rotation);
    }
    public void CoinGenerate()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomZ = Random.Range(2f, 3f);
        float randomY = Random.Range(.9f, 1f);
        int rnd = Random.Range(1, 3);
        addRandomPos = new Vector3(randomX,randomY,randomZ);
        Debug.Log(rnd);
       switch(rnd%3)
        {
            case 0:
                {
                    Instantiate(coin5pt, playerObj.transform.position + addRandomPos, coin5pt.transform.rotation);
                  
                }
                break;
            case 1:
                {
                 
                  Instantiate(coin10pt, playerObj.transform.position + addRandomPos, coin10pt.transform.rotation);
                  
                }
                break;
            case 2:
                {
                     Instantiate(gem, playerObj.transform.position + addRandomPos, gem.transform.rotation);
                 
                }
                    break;


        }

    }

}

