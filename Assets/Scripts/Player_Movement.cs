using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 5;

    // Update is called once per frame
    void Update(){
        
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(0,0,0);

        if(HorizontalMovement != 0){
            direction.x = HorizontalMovement;
        }

        if(VerticalMovement != 0){    
            direction.z = VerticalMovement;
        }

        transform.Translate(direction * (speed * Time.deltaTime));
    }
}
