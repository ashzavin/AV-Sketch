using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_grab_control : MonoBehaviour
{
    public GameObject anVideo1;
    //public GameObject prayer_time_greet;
    //public GameObject prayer_muslim_man;
    //public GameObject prayer_muslim_man1;

    //public GameObject way_char2;
    //public GameObject prayer_recite;

    int flag_interfaith = 0;
    void Update()
    {
        if (GetComponent<OVRGrabbable>().m_grabbedBy != null)
        {
            anVideo1.SetActive(true);
        }
    }
}
