using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class HapticFeedbackManager : MonoBehaviour
{
    public float frequency = 1f;
    public float amplitude = 1f;

    private void OnCollisionEnter(Collision collision)
    {
        OVRInput.SetControllerVibration(frequency, amplitude, OVRInput.Controller.RTouch);
    }

    private void OnCollisionExit(Collision collision)
    {
        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
    }

    public void decreaseVibration()
    {

    }
    public void increaseVibration()
    {

    }

}
