using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    
    public class CarUserControl : MonoBehaviour
    {
        TextMesh DebugText;
        string debugMessage = "Default message";

        private CarController m_Car; // the car controller we want to use
        float steering;
        float accel;
        float footbrake;
        float handbrake;
        public Vector3 angletoRotate;

        public bool drive = false;
        public float startTime = 0.0f;

        float flag = 0;        //to check if the button has been pressed or not

        //Set to limit when the interaction is allowable
        public float triggerAllowStart = 0.0f;
        public float triggerAllowEnd = 4.6f; //time

        //For a yet unknown reason, the quest will use the last value of this number used, not the current one
        public float interactionTriggerPoint = 4.6f;

        private void Awake()
        {
            GameObject DebugObject = GameObject.FindGameObjectWithTag("Debug");
            DebugText = (TextMesh)DebugObject.GetComponent("TextMesh");

            // get the car controller
            m_Car = GetComponent<CarController>();
            

            //Initialize values
            steering = 0.0f;
            accel = 0.0f;
            footbrake = 0.0f;
            handbrake = 0.0f;
        }


        private void FixedUpdate()
        {

            if (drive)
            {
                debugMessage = "Time: " + Time.time + "  Trigger: " + (startTime + interactionTriggerPoint);
                DebugText.text = debugMessage;

                m_Car.setTopSpeed(10);
                accel = 1.0f;
            }
            else
            {
                if(Time.time > (startTime+interactionTriggerPoint))
                {
                    debugMessage = "Time: " + Time.time + "  Trigger: " + (startTime + interactionTriggerPoint);
                    DebugText.text = debugMessage;

                    accel = 0.0f;
                    m_Car.decreaseTopSpeed(0.5f);
                }

                //Added by Asha to restart the car again after stopping in crosswalk
                if (m_Car.m_Topspeed == 0 && flag==1)
                {
                        Invoke("carStart", 5);
                }
                
            }

            m_Car.Move(steering, accel, footbrake, handbrake);
        }

        public void buttonInteraction()
        {
            if((Time.time > (startTime + triggerAllowStart)) && 
               (Time.time < (startTime + triggerAllowEnd)))
            {
                interactWithVehicle();
            }

          
        }

        public void interactWithVehicle()
        {
            drive = false;
            flag = 1;
        }

        public void carStart()      //Making drive true again for restarting the car
        {
            drive = true;
        }

        public void reset()
        {
            drive = false;
            flag = 0;
            accel = 0.0f;
            m_Car.decreaseTopSpeed(0.5f);

            if (m_Car.m_Topspeed==0)
            {
                this.transform.position = new Vector3(4f, 0f, 30f);
            }
        }
    }
}


