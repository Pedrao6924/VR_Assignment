using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplianceManager : MonoBehaviour
{
    public GameObject appliance;
    public bool isOcupied = false;
    Vector3 spawnLocation = new Vector3(-18.95f,0.5f,27.92f);

    
    public void SpawnAppliance(GameObject app){

        if(isOcupied){
            Destroy(appliance);
        }
        GameObject obj = Instantiate(app, spawnLocation, new Quaternion(0,180,0,0));
        appliance = obj;
        isOcupied=true;
    }
    
}
