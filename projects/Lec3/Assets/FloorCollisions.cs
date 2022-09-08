using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollisions : MonoBehaviour
{
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision context){
        Debug.Log("Something collided with me!");
        Material matFile = Resources.Load<Material>("floor_stone") as Material;
        renderer.material = matFile;
    }
}
