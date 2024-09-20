using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    int collisionCount = 0;
    //Collision
    private void OnCollisionEnter(Collision other)
    {
        collisionCount++;
        Debug.Log("You've collided with the wall " + collisionCount + " times");   

        if(other.gameObject.tag == "Player")
        {
            // gets class as input
            GetComponent<MeshRenderer>().material.color = Color.gray;
        }
       
    }
}

