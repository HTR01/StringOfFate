using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupTransport : MonoBehaviour
{
    //If object enters and layer is == to pickups, destroy object and instantiate it at X paired position.
    public GameObject pickupFab;
    public Transform telePos;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            Instantiate(pickupFab, telePos.position, telePos.rotation);
        }
    }
}
