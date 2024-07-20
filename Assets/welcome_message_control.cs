using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcome_message_control : MonoBehaviour
{
    public GameObject wel_chi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Welcome_Play", 5);
    }

    public void Welcome_Play()
    {
        wel_chi.SetActive(true);
    }
}
