using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LineRendererTest : MonoBehaviour {
    public Image Gaze;
    private LineRenderer LR;
    RaycastHit RayHitInfo;
     
	void Start ()
    {
        LR = GetComponent<LineRenderer>();

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote), 0.2f);
    }
    // Update is called once per frame
    void Update ()
    {
        LR.SetPosition(0, OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote));
        Vector3 forward = transform.TransformDirection(OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote));
        LR.SetPosition(1, transform.forward * 50);
        if (Physics.Raycast(new Vector3 (OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote).x * 100, 
            OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote).y * 100,
            OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote).z * 100), 
            transform.forward, out RayHitInfo, Mathf.Infinity))
        {
            if (RayHitInfo.collider)
            {
                Gaze.transform.position = RayHitInfo.point;
            }else
            {
                Gaze.transform.position = new Vector3(RayHitInfo.point.x, RayHitInfo.point.y, 6.4f);
            }
        }

    }
}
