
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticFeedback : MonoBehaviour
{
    void Start()
    {
    }

    private bool inCollision = false;
    private string colliderName = "";

    // slight vibrations on collision
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("Controller  collision entering" + collision.transform.name);

        inCollision = true;
        // colliderName = collision.transform.name;
        OVRInput.SetControllerVibration(1,1,OVRInput.Controller.RTouch);
    }

    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        Debug.Log("Controller  collision exiting" + collision.transform.name);

        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
    }
}
