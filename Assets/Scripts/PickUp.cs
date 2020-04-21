using UnityEngine;

public class PickUp : MonoBehaviour
{ 
    public KeyCode pickup;
    public Transform pickupPos;
    public ObjectPhysics holding;
    public DetectorPickUp detector;
    Animator anim;

    private void Start()
    {
        holding = null;
    }

    private void Update()
    {
      if (Input.GetKeyDown(pickup) && detector.closestObject != null && holding == null)
       {
            detector.closestObject.Pickup(pickupPos);
            holding = detector.closestObject;
        }
        else if (Input.GetKeyDown(pickup) && holding != null)
        {
            holding.DropObject();
            holding = null;
        }


    }

    

}
