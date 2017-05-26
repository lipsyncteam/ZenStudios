using UnityEditor;
using UnityEngine;

public class EditorMousetoGearVR : MonoBehaviour
{
    [MenuItem ("LipSync GearVR/Mouse Enable")]
    static void MouseTestingEnable()
    {
        GameObject.FindGameObjectWithTag("TrailRenderer").GetComponent<OVR_Controller>().enabled = false;
        GameObject.FindGameObjectWithTag("TrailRenderer").GetComponent<MouseDraw>().enabled = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<OVRMenu>().enabled = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<MouseLevelScript>().enabled = true;
    }

    [MenuItem("LipSync GearVR/Mouse Disable")]
    static void MouseTestingDisable()
    {
        GameObject.FindGameObjectWithTag("TrailRenderer").GetComponent<OVR_Controller>().enabled = true;
        GameObject.FindGameObjectWithTag("TrailRenderer").GetComponent<MouseDraw>().enabled = false;

        GameObject.FindGameObjectWithTag("Player").GetComponent<OVRMenu>().enabled = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<MouseLevelScript>().enabled = false;
    }

    [MenuItem("LipSync GearVR/Time 60FPS")]
    static void SettingTimeFrames()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.0166666f;
    }

    [MenuItem("LipSync GearVR/VR Disable")]
    static void VRDisable()
    {
        PlayerSettings.virtualRealitySupported = false;
    }
}
