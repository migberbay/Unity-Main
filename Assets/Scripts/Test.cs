using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    public int publicNum;
    private int privateNum;
    

    // Start is called before the first frame update
    void Start(){
      GameObject player = GameObject.FindGameObjectWithTag("Player");
      GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
      GameObject boss = GameObject.Find("BOSS");
      Debug.Log(boss);
      Debug.Log(player);
      for (int i = 0; i < 4; i++)
      {
          Debug.Log(enemies[i]);
      }
      Invoke("method", 1.0f);
      InvokeRepeating("method", 3.0f, 5.0f);
    }

    // Update is called once per frame
    void Update(){
      
    }

    private void Awake() {
        
    }

    private void FixedUpdate() {
        //This should be used for calculations that need to occur regularly
        //for example object motion
        if(privateNum>3){
          CancelInvoke();
        }
       
    }

    private void method(){
      Debug.Log("I HAVE A BIG PEEPEEE" + Time.time);
      privateNum++;
    }
}
