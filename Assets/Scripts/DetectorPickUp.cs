using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPickUp : MonoBehaviour
{
    public ObjectPhysics closestObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ObjectPhysics>() != null)
        {
            closestObject = collision.gameObject.GetComponent<ObjectPhysics>();
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ObjectPhysics>() == closestObject)
        {
            closestObject = null;
            
        }
    }
}
