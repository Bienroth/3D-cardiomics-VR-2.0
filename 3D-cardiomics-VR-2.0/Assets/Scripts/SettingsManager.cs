using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{


    void OnCollisionEnter(Collision collision)
    {

        if (gameObject.name == "HandBtn")
        {
            switch (gameObject.GetComponentInChildren<Slider>().value)
            {
                case 0: gameObject.GetComponentInChildren<Slider>().value = 1;
                        // Switched to Right Hand
                        //TBD

                        break;
                case 1: gameObject.GetComponentInChildren<Slider>().value = 0;
                        // Switched to Left Hand
                        //TBD
                        break;
            }
        }

        if (gameObject.name == "DecreaseVibration")
        {
          if(GameObject.Find("Detector_R") != null){
                GameObject.Find("Detector_R").GetComponent<HapticFeedbackManager>().decreaseVibration();
            }
        }

        if (gameObject.name == "IncreaseVibration")
        {
            if (GameObject.Find("Detector_R") != null)
            {
                GameObject.Find("Detector_R").GetComponent<HapticFeedbackManager>().increaseVibration();
            }
        }


    }
}
