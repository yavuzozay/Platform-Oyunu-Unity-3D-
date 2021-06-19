using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 playerFirstPos;
    [SerializeField] Vector3 camPositionSettings;


    private void Awake()
    {
        playerFirstPos = player.transform.position;
        transform.position = camPositionSettings;
    }

    void Update()
    {
        Vector3 playerPosDif = player.transform.position-playerFirstPos;
        gameObject.transform.position =playerPosDif+camPositionSettings ;
    }
}
