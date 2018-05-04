using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
	
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
		public float h;
		public float v;

		public bool generateData = true;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!

			if (generateData == true) {
				h = CrossPlatformInputManager.GetAxis ("Horizontal");
				v = CrossPlatformInputManager.GetAxis ("Vertical");
			} 

#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
			//Debug.Log(h);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
