using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeAppliances : MonoBehaviour
{

    public Material fridgeMat;
    public Material stoveMat;
    public Material vaccumeMat;

    public ApplianceManager applianceManager;
    public Color newColor;


    void OnCollisionEnter(Collision col){
        fridgeMat.color = newColor;
        stoveMat.color = newColor;
        vaccumeMat.color = newColor;
    }

}
