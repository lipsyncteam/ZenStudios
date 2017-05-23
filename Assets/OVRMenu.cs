using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRMenu : MonoBehaviour {

    public RaycastHit RayHitInfo;
    public GameObject Brush;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ContollerPosition();

    }

    void ContollerPosition()
    {
        Brush.transform.position = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);

    }
}
