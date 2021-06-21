using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpTrigger : MonoBehaviour

{
    [SerializeField] GameObject o;
    GameObject player;
  
    PrefabGenerator generator;
    PlayerController playerController;
     void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerController>();
        generator = o.GetComponent <PrefabGenerator>();
    }
   
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            playerController.pSpeed += .15f;
            generator.EngelGenerate();
            generator.Generate();
            generator.CoinGenerate();
        }
           
    }
}
