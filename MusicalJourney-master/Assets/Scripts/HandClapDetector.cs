using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandClapDetector : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public PlayerMovementConstant playerMovementConstant;

    public GameObject startText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "HandClap"){
            playerMovement.startMoving();
            playerMovementConstant.startMoving();
            Destroy(startText);
        } 
    }
}
