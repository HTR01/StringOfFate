using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{ 
    public DetectorPickUp DPU;
    public PlayerMovement PM;
    public ObjectPhysics OP;

    private void Update()
    {
      if (Input.GetKeyDown(PM.pickup) && DPU.closestObject != null)
       {
            //OP.body.MovePosition(OP.body.position + new Vector2(0, OP.pickupAmount));
        }

    }

    

}
