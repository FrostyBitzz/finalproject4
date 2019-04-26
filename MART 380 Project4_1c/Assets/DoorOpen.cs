using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animation BasementDoor;
    public GameObject Door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            if (Input.GetKey("e"))
            {
                BasementDoor.Play ();
            }


    }
}