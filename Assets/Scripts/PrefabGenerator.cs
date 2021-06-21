using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject coin5pt;
    public GameObject coin10pt;
    public GameObject gem;
    public GameObject playerObj;
    public GameObject engelObj;


    public GameObject sonKonum;
 
 


    private void Awake()
    {
        Generate();
       
        

    }
    private void Update()
    {
        Debug.Log(""+sonKonum.transform.position.x);
    }
    public void Generate()
    {


        sonKonum = Instantiate(sonKonum, sonKonum.transform.position + Vector3.forward*4.7f, sonKonum.transform.rotation);
    }
    public void EngelGenerate()
    {

        float randomZ = Random.Range(1.5f, 3f);       
       float  randomX = Random.Range(sonKonum.transform.position.x - 2f, sonKonum.transform.position.x + 2f);
        Vector3 playerPosZ = new Vector3(0, 0, playerObj.transform.position.z);
        Vector3 addRandomPos = new Vector3(randomX, 0, randomZ);
        Instantiate(engelObj, playerPosZ+ addRandomPos, engelObj.transform.rotation);
    }

    public void CoinGenerate()
    {
        float randomX = Random.Range(-2f, 2f);
        float randomZ = Random.Range(1.5f, 3f);
        float randomY = Random.Range(0.3f,0.5f);
        int rnd = Random.Range(1, 5);
        randomX= Random.Range(sonKonum.transform.position.x - 2f, sonKonum.transform.position.x + 2f);
        Vector3 playerPosZ = new Vector3(0,playerObj.transform.position.y,playerObj.transform.position.z);

        Vector3 addRandomPos = new Vector3(randomX,randomY,randomZ);
        Debug.Log("random: "+rnd);
       switch(rnd%3)
        {
            case 0:
                {
                    Instantiate(coin5pt, playerPosZ + addRandomPos, coin5pt.transform.rotation);
                    Instantiate(coin5pt, playerPosZ + addRandomPos+new Vector3(Random.Range(-.3f,.3f),0,+1f), coin5pt.transform.rotation);
                    Instantiate(coin5pt, playerPosZ + addRandomPos + new Vector3(Random.Range(-.3f, .3f), 0, +2f), coin5pt.transform.rotation);


                }
                break;
            case 1:
                {
                 
                  Instantiate(coin10pt, playerPosZ + addRandomPos, coin10pt.transform.rotation);
                  Instantiate(coin10pt, playerPosZ + addRandomPos+ new Vector3(Random.Range(-.3f, .3f), 0, +1f), coin10pt.transform.rotation);

                }
                break;
            case 2:
                {
                     Instantiate(gem, playerPosZ + addRandomPos, gem.transform.rotation);
                   
                 
                }
                    break;


        }

    }

}

