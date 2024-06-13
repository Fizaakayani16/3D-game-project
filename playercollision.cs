using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
     public playermovement movement;
      void OnCollisionEnter(Collision collisionInfo)
      
    {
    if(collisionInfo.collider.tag == "rock")
        {
            Debug.Log("Obstacle Dectected");
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().GameOver();

        }

    }
}
