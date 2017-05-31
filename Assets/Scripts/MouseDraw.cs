using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDraw : MonoBehaviour
{


    public GameObject DrawPlaceBrush;
    public RaycastHit RayHitInfo;

    void Start()
    {
        HitCollision.CCName = null;
        HitCollision.CCcount = 0;
        HitCollision.HitBrush = false;
        HitCollision.ResetColor = false;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(DrawPlaceBrush.transform.position, Mathf.Infinity);
    }
    void MouseDrawFunc()
    {

        if (Input.GetMouseButton(0))
        {         
            if (Physics.Raycast(DrawPlaceBrush.transform.position, DrawPlaceBrush.transform.forward, out RayHitInfo, Mathf.Infinity))
            {
                if (RayHitInfo.collider)
                {
                    this.transform.position = RayHitInfo.point;
                    GetComponent<TrailRenderer>().enabled = true;
                }
                else
                {
                    // ResetLineRenderer();
                }
            }
        }
        else
        {
            //ResetLineRenderer();
        }


        Debug.DrawRay(transform.position,transform.forward, Color.green);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(DrawPlaceBrush.transform.position, DrawPlaceBrush.transform.forward, out RayHitInfo, Mathf.Infinity))
            {

                if (RayHitInfo.collider.tag == "CC" + HitCollision.CCcount)
                {
                    HitCollision.CCName = RayHitInfo.collider.tag;
                    HitCollision.HitBrush = true;
                }
                else
                {
                    HitCollision.HitBrush = false;
                }

                if (RayHitInfo.collider.tag == "ResetColor")
                {
                    HitCollision.ResetColor = true;
                }
                else
                {
                    HitCollision.ResetColor = false;
                }

            }
            else
            {
                HitCollision.HitBrush = false;
            }




        }
        else
        {
            if (Physics.Raycast(DrawPlaceBrush.transform.position, DrawPlaceBrush.transform.forward, out RayHitInfo, Mathf.Infinity))
            {
                if (RayHitInfo.collider.tag == "ResetColor")
                {
                    HitCollision.ResetColor = true;
                  
                }
                else
                {
                    HitCollision.ResetColor = false;
                }
            }
        }
    }

    private void ResetLineRenderer()
    {
        GetComponent<TrailRenderer>().enabled = false;
        GetComponent<TrailRenderer>().Clear();
    } 

    private void Update()
    {
#if UNITY_EDITOR
        MouseDrawFunc();
#endif

     
    }
}
