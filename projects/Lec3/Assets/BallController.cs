using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float speed = 200f;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            
            rigidbody.AddForce(new Vector3(-1f,0,0) * speed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            
            rigidbody.AddForce(new Vector3(1f,0,0) * speed, ForceMode.Force);
        }
        
    }

    void OnCollisionEnter(Collision context){
        Debug.Log("I collided! Yay!");
    }
}
