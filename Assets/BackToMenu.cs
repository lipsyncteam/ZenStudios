using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    
	
	
	void Update ()
    {
        if (OVRInput.GetDown(OVRInput.Button.Back))
        {
            Application.LoadLevel("ZenStudiosMainMenu");
        }
	}
}
