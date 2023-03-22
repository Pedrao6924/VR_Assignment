using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractFrezzerDoor : MonoBehaviour
{
    bool isOpen = false;
    public Transform point;
    float speed = 100f;

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag != "PlayerHand"){
            return;
        }

        if(!isOpen){
            transform.RotateAround(point.position, Vector3.right, speed);
            isOpen=true;
        }else{
            transform.RotateAround(point.position, Vector3.right, -speed);
            isOpen= false;
        }
    }
}
