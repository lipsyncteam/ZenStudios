using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

    private LineRenderer LR;
    public RaycastHit RayHitInfo;
    public float LaserSpaceFromOrgin;
    void Start ()
    {
        LR = GetComponent<LineRenderer>();
        LR.SetPosition(0, new Vector3(transform.position.x, transform.position.y, transform.position.z + LaserSpaceFromOrgin));
    }
	
	
	void Update ()
    {
        Vector3 forward = transform.TransformDirection(transform.forward);
        LR.SetPosition(0, new Vector3(transform.position.x, transform.position.y, transform.position.z + LaserSpaceFromOrgin));

        if (Physics.Raycast(transform.position, forward, out RayHitInfo, Mathf.Infinity))
        {
            if (RayHitInfo.collider)
            {
                LR.SetPosition(1, RayHitInfo.point);
            }

        }
        else
        {
            LR.SetPosition(1, forward * 50);
        }
        
	}
}
