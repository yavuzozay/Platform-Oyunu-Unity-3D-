using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTriggerControl : MonoBehaviour
{
   
    GameObject player;
    PrefabGenerator generator;
    PlayerController playerController;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<PlayerController>();
      
    }
    private void Update()
    {
        Debug.Log("aaaaaaaaa"+playerController.pSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        playerController.pcanMove = true;
    }
   
}
