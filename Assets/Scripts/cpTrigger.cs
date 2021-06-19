using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpTrigger : MonoBehaviour

{
    [SerializeField] GameObject o;
    PrefabGenerator generator;
     void Awake()
    {
        generator = o.GetComponent <PrefabGenerator>();
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("aaa");
        if (other.gameObject.CompareTag("Player"))
        {
            generator.Generate();
            generator.CoinGenerate();
        }
           
    }
}
