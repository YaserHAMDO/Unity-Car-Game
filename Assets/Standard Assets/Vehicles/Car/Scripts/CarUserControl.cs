using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{

    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour 
    {
        private CarController m_Car; // the car controller we want to use
        private int input;
        private int input2;

        ForwardButton forwardButton;
        BackButton backButton;
        RightButton rightButton;
        LeftButton leftButton;
       

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }
        private void Start()
        {
            backButton = GameObject.Find("BackWard").GetComponent<BackButton>();
            forwardButton = GameObject.Find("Forward").GetComponent<ForwardButton>();
            rightButton = GameObject.Find("Right").GetComponent<RightButton>();
            leftButton = GameObject.Find("Right").GetComponent<LeftButton>();

            BackButton.instance.SetPlayer(this.gameObject);
            ForwardButton.instance.SetPlayer(this.gameObject);
            RightButton.instance.SetPlayer(this.gameObject);
            LeftButton.instance.SetPlayer(this.gameObject);
        }
        float handbreake;
        private void FixedUpdate()
        {
            // pass the input to the car!
            float h =SimpleInput.GetAxis("Horizontal");
            float v = SimpleInput.GetAxis("Vertical");
      
            // float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            if (Input.GetKey(KeyCode.Space))
            {
                handbreake = 1;
            }
            else
            {
                handbreake = 0;
            }
            m_Car.Move(input2, input, input, handbreake);
          
        }

        public void Forward()
        {
            input = 1;
        }

        public void Backward()
        {
            input = -1;
        }


        public void PointerUp()
        {
            input = 0;
        }



        public void Left()
        {
            input2 = -1;
        }

        public void Right()
        {
            input2 = 1;
        }

        public void PointerUp2()
        {
            input2 = 0;
        }


        /*
        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
      */
    }


}
