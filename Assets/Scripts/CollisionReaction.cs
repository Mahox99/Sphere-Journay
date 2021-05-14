using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReaction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacles")
        {
            Debug.Log("Kolizja!");
            MoveControler.hor = 0;
            MoveControler.ver = 0;
        }
        
    }
}
