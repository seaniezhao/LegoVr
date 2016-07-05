using System;
using System.Collections.Generic;
using UnityEngine;
using Leap;

namespace Leap.Unity.PinchUtility
{
    public class ShapeContorller : MonoBehaviour
    {
        public LeapRTS m_LeapRTS;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (m_LeapRTS.PinchDetectorA.IsPinching)
            {
                Vector3 distance = m_LeapRTS.PinchDetectorA.Position - this.transform.position;
                if (distance.sqrMagnitude < 0.01)
                {
                    this.transform.position = m_LeapRTS.PinchDetectorA.Position;
                    this.transform.rotation = m_LeapRTS.PinchDetectorA.Rotation;
                }
            }

            if (m_LeapRTS.PinchDetectorA.IsPinching && m_LeapRTS.PinchDetectorB.IsPinching)
            {
                Vector3 distance_a = m_LeapRTS.PinchDetectorA.Position - this.transform.position;
                Vector3 distance_b = m_LeapRTS.PinchDetectorB.Position - this.transform.position;
                if (distance_a.sqrMagnitude < 0.01 && distance_b.sqrMagnitude < 0.01)
                {
                    this.transform.localScale = Vector3.one * Vector3.Distance(m_LeapRTS.PinchDetectorA.Position, m_LeapRTS.PinchDetectorB.Position);
                }
            }
        }
        
        void OnTriggerEnter(Collider c)
        {

        }
    }
}
