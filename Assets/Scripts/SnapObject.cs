using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    public GameObject SnapLocation;
    public bool isSnapped;

    private bool objectSnapped;
    private bool grabbed;


    // Update is called once per frame
    void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;
        objectSnapped = SnapLocation.GetComponent<SnapToLocation>().Snapped;

        if(objectSnapped==true)
        {
            GetComponent<MeshRenderer>().enabled = false;
            isSnapped = true;
        }
        
    }
}
