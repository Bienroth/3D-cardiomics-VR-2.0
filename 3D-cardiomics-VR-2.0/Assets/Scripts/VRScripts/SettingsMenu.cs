using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public Text deviceText;
    public GameObject settingsMenu;
    private string deviceName;

    // Update is called once per frame
    void Start()
    {
        deviceName = "Connected device: ";
        Debug.Log(OVRPlugin.productName);
        switch (OVRPlugin.GetSystemHeadsetType())
        {
            case (OVRPlugin.SystemHeadset.Oculus_Quest+1):
                deviceName += "Oculus"; break;
            case (OVRPlugin.SystemHeadset.Rift_S):
                deviceName += "Oculus";
                break;
            case (OVRPlugin.SystemHeadset.Oculus_Quest):
                deviceName += "Oculus"; break;
        }
        deviceText.text = deviceName;
    }

    public void exitApplication()
    {
        Application.Quit();
    }

    public void resumeApplication()
    {
        settingsMenu.SetActive(false);

    }

    public void showOptions()
    {
        //TBD
    }
}
