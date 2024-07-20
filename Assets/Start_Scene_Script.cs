using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Scene_Script : MonoBehaviour
{
    float startTime;
    public GameObject morning1;
    public GameObject morning2;
    public GameObject greeting1;
    public GameObject greeting2;
    public GameObject shower;
    public GameObject way_char;

    public GameObject morning3;
    public GameObject morning4;
    public GameObject morning5;
    public GameObject greeting3;
    public GameObject greeting4;
    public GameObject greeting5;

    void Start()
    {
        startTime = Time.time;
        Invoke("audio_morning_Start", 10);
    }

    public void audio_morning_Start()
    {
        morning1.SetActive(true);
        Invoke("first_Conv_Start", 10);
    }

    public void first_Conv_Start()
    {
        greeting1.SetActive(true);
        morning2.SetActive(true);

        Invoke("shower_point", 60);
        Invoke("shower_take", 75);
    }

    public void shower_point()
    {
        greeting1.SetActive(false);
        greeting2.SetActive(true);

    }

    public void shower_take()
    {
        shower.SetActive(true);
        greeting2.SetActive(false);


        Invoke("dress_wear", 15);


    }
    public void dress_wear()
    {
        Vector3 temp = new Vector3(0, 0, 0);
        way_char.transform.position = temp;

        greeting3.SetActive(true);
        morning3.SetActive(true);

        Invoke("attir_wear", 35);

    }

    public void attir_wear()
    {
        greeting3.SetActive(false);
        greeting4.SetActive(true);
        morning4.SetActive(true);

        Invoke("eat_food", 20);

    }

    public void eat_food()
    {
        greeting4.SetActive(false);
        greeting5.SetActive(true);
        morning5.SetActive(true);

    }
}
