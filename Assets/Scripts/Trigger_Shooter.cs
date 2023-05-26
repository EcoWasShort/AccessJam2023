using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Shooter : MonoBehaviour
{
    public GameObject LogShooterObject;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            //LogShooter
            LogShooterObject.GetComponent<Log_Shooter>().ShootLog("Ciao");
        }
    }
}
