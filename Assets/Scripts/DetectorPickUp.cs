using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPickUp : MonoBehaviour
{
    public PickUp closestObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PickUp>() != null)
        {
            closestObject = collision.gameObject.GetComponent<PickUp>();
            Debug.Log("Not null");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PickUp>() == closestObject)
        {
            closestObject = null;
            Debug.Log("Null");
        }
    }
}
