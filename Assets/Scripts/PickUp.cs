using UnityEngine;

public class PickUp : MonoBehaviour
{ 
    public KeyCode pickup;
    public Transform pickupPos;
    public ObjectPhysics holding;

    private void Start()
    {
        holding = null;
    }

    private void Update()
    {
      if (Input.GetKeyDown(pickup) && DetectorPickUp.closestObject != null && holding == null)
       {
            DetectorPickUp.closestObject.Pickup(pickupPos);
            holding = DetectorPickUp.closestObject;

        }
        else if (Input.GetKeyDown(pickup) && holding != null)
        {
            holding.DropObject();
            holding = null;
        }


    }

    

}
