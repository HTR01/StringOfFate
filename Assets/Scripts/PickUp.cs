using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{ 
    
    
    public ObjectPhysics OP;

    public KeyCode pickup;

    public KeyCode pickup2;

    private void Start()
    {
        
    }

    private void Update()
    {
      if (Input.GetKeyDown(pickup) && DetectorPickUp.closestObject != null)
       {
            OP.Pickup();
       }

      if (Input.GetKeyDown(pickup2) && DetectorPickUp.closestObject != null)
       {
            OP.Pickup();
       }

    }

    

}
