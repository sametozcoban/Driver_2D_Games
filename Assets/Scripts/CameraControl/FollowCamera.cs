using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Driver.CameraControl
{ 
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private GameObject followToPlayer;
    
        Vector3 cameraPosition = new Vector3(0, 0, -10);
        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = followToPlayer.transform.position + cameraPosition;
        }
    }
}