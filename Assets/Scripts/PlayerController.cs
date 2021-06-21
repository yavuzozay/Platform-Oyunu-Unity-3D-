using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
   

{
    RaycastHit verticalHit;
    RaycastHit horizontalHit;
    CharacterController characterController;
     float speed=1;
    [SerializeField] float jump;
    [SerializeField] float verticalSpeed;
    [SerializeField] float horizontalSpeed;
    private float gravity = -9.81f;
    float mSpeedY = 0;
    public bool canMove;
    bool gameActive;

    public float pSpeed
    {
        get { return speed; }
        set { speed = value; }
    }
    public bool pcanMove
    {
        get { return canMove; }
        set { canMove = value; }
    }
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        canMove = false;
        gameActive = true;
      

    }

    void Update()
    {
        Move();
      //  Debug.Log("speed: " + canMove);
        HitControl();
        GameControl();
      

    }
   
    void HitControl()

    {

        if(Physics.Raycast(transform.position,new Vector3(0f,-1f,0),out verticalHit,.5f))
        {

            Debug.DrawLine(transform.position, verticalHit.point, Color.red);
            Debug.Log(verticalHit.collider.gameObject);
                
            if (verticalHit.collider.CompareTag("Engel"))
            {
                canMove = false;

                gameActive = false;

            }
        }
        if (Physics.Raycast(transform.position, new Vector3(0f, .5f, 1f), out horizontalHit,.5f))
        {
            Debug.DrawLine(transform.position, horizontalHit.point, Color.red);

          if (horizontalHit.collider.CompareTag("Engel"))
            {

               canMove = false;

                gameActive = false;
           }
       }
    }
    void GameControl()
    {
        if(!gameActive)
        {
            PlayerPrefs.SetInt("score", ScoreManager.score);
            SceneManager.LoadScene(2);

        }

    }

    private void Move()
    {
    

       
     if (!characterController.isGrounded)
            mSpeedY += gravity * Time.deltaTime;
           
        
     else
         mSpeedY = 0;
            
        
        float x = Input.GetAxisRaw("Horizontal");

        Vector3 movement = new Vector3(0, 0, speed) + new Vector3(x * horizontalSpeed, 0, 0);

        Vector3 verticalMovement = Vector3.up * mSpeedY * Time.deltaTime;

        characterController.Move(verticalMovement);
        if(canMove)
            characterController.Move(verticalMovement + (movement * Time.deltaTime));
        
      
    }
}
