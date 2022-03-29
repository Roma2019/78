using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontroller : MonoBehaviour
{
    Rigidbody rb;
    public static int badScore = 0;
    public static int goodScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag== "good"){
            rb.AddForce(2f,140f,0);
        }
        if(col.gameObject.tag== "bad"){
            badScore = badScore + 1;
            if(badScore == 6){
                print("you loose");
            }
        }
    }
    void OnMouseDown(){
        goodScore = goodScore + 1;
        Destroy(gameObject);
        if(goodScore == 6){
            print("you win!");
        }
    }
}
