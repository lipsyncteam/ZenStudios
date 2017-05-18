using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVR_Controller : MonoBehaviour {



    private bool trigger_is;
    private RaycastHit HitInfo;
    public GameObject Cube;
	void Start ()
    {
        

    }
	
	
	void Update ()
    {
        Vector3 forwardSight = transform.TransformDirection(transform.forward);
        trigger_is = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger);
        if(Physics.SphereCast(OVRInput.GetLocalControllerPosition(OVRInput.Controller.Remote),1f,forwardSight, out HitInfo, 10f))
        {
            print(HitInfo.collider.gameObject);
            if(HitInfo.collider.tag == "Scroll")
            {
                Cube.GetComponent<Renderer>().material.color = Color.red;
            }else
            {
                Cube.GetComponent<Renderer>().material.color = Color.white;

            }
        }
        print(trigger_is);
    }
}
