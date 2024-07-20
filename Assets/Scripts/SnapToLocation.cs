using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToLocation : MonoBehaviour
{

    private bool grabbed;
    private bool insideSnapZone;
    public bool Snapped;

    public GameObject SnapRotationReference;
    public GameObject itemOnePart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name== itemOnePart.name)
        {
            insideSnapZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == itemOnePart.name)
        {
            insideSnapZone = false;
        }
    }

    void SnapObject()
    {
        if (grabbed == false && insideSnapZone== true)
        {
            itemOnePart.gameObject.transform.position = transform.position;
            itemOnePart.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
            Snapped = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        grabbed = itemOnePart.GetComponent<OVRGrabbable>().isGrabbed;
        SnapObject();
    }
}
