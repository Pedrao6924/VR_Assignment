using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAppliances : MonoBehaviour
{
    public GameObject appliance;
    public ApplianceManager spawn;

    void OnCollisionEnter(Collision col){
        spawn.SpawnAppliance(appliance);
    }
    
}
