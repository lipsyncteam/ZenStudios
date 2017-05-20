using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVR_Controller : MonoBehaviour
{
 
    
    public RaycastHit RayHitInfo;
    public GameObject Brush;
    void OVR_Controller_DrawFunc()
    {

        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {

            if (Physics.Raycast(OVRInput.GetLocalControllerPosition(OVRInput.Controller.Remote), transform.forward, out RayHitInfo, 2.38f))
            {

                if (RayHitInfo.collider.tag == "Scroll" && OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                {
                    this.transform.position = RayHitInfo.point;
                    GetComponent<TrailRenderer>().enabled = true;
                }
                else
                {
                    ResetLineRenderer();


                }
            }
        }
        else
        {
           // ResetLineRenderer();
        }


        Debug.DrawRay(OVRInput.GetLocalControllerPosition(OVRInput.Controller.Remote), transform.forward, Color.blue);
    }

    private void ResetLineRenderer()
    {
        GetComponent<TrailRenderer>().enabled = false;
        GetComponent<TrailRenderer>().Clear();
    }

    void ContollerPosition()
    {
        Brush.transform.position = OVRInput.GetLocalControllerPosition(OVRInput.Controller.Remote);
    }

    void Update ()
    {
        OVR_Controller_DrawFunc();
        ContollerPosition();
    }

    
}
