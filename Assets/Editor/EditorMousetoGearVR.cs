using UnityEditor;
using UnityEngine;

public class EditorMousetoGearVR : MonoBehaviour
{
    [MenuItem ("LipSync GearVR/Mouse Enable")]
    static void MouseTestingEnable()
    {
        
    }

    [MenuItem("LipSync GearVR/Mouse Disable")]
    static void MouseTestingDisable()
    {
        
    }

    [MenuItem("LipSync GearVR/Time 60FPS")]
    static void SettingTimeFrames()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.0166666f;
    }

    
}
