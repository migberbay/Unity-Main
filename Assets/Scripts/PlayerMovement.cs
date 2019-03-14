using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump")){
            Debug.Log("YOU PRESSED DOWN SPACEBAR");
        }else if (Input.GetButton("Jump")){
            Debug.Log("YOU ARE PRESSING SPACEBAR");
        }else if (Input.GetButtonUp("Jump")){
            Debug.Log("YOU RELEASED SPACEBAR");
        }

        if(h<0){
            Debug.Log("moving left");
        }else if(h>0){
            Debug.Log("moving right");
        }

        if(v<0){
            Debug.Log("moving down");
        }else if(v>0){
            Debug.Log("moving up");
        }
        
        if(Input.GetKeyDown(KeyCode.N)) {
            Debug.Log("ARE U TYPING THE N-WORD? YOU FUCKING NIGGER");
        }

        
    }
}
