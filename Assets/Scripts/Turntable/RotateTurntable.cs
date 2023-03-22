using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTurntable : MonoBehaviour
{
    public GameObject turnTable;
    public bool clockWise;
    float speed = 50.0f;

    public ApplianceManager applianceManager;

    public AudioSource audio;
    void OnCollisionEnter(Collision col){
        audio.mute = false;
    }
    void OnCollisionExit(Collision col){
        audio.mute = true;
    }

    void OnCollisionStay(Collision col)
        {

            
            if(col.gameObject.tag == "PlayerHand"){
                if(clockWise){
                    turnTable.transform.Rotate(Vector3.up * speed * Time.deltaTime);
                    applianceManager.appliance.transform.Rotate(Vector3.up * speed * Time.deltaTime);
                } else {
                    turnTable.transform.Rotate(Vector3.up * -speed * Time.deltaTime);
                    applianceManager.appliance.transform.Rotate(Vector3.up * -speed * Time.deltaTime);
                }
            }
        }
   
}
