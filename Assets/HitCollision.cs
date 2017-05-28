using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCollision : MonoBehaviour {

    public RaycastHit RayHitInfo;
   
    public static string CCName;
    public static int CCcount;
    public static bool HitBrush;
    public static bool ResetColor;
    void Start ()
    {
        CCName = null; 
        CCcount = 0;
        HitBrush = false;
        ResetColor = false;
    }
	
	

	void Update ()
    {
        Vector3 forward = transform.TransformDirection(transform.forward);
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (Physics.Raycast(transform.position, forward, out RayHitInfo, Mathf.Infinity))
            {
                
                if (RayHitInfo.collider.tag == "CC" + CCcount)
                {
                    HitBrush = true;
                    CCName = RayHitInfo.collider.tag;
                }
                else
                {
                    HitBrush = false;

                }

                if (RayHitInfo.collider.tag == "ResetColor")
                {
                    ResetColor = true;
                }else
                {
                    ResetColor = false;
                }

            }
        }        
    }
}
