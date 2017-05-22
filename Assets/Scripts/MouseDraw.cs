using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDraw : MonoBehaviour
{


    public GameObject DrawPlaceBrush;
    public RaycastHit RayHitInfo;
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(DrawPlaceBrush.transform.position, 0.2f);
    }
    void MouseDrawFunc()
    {

        if (Input.GetMouseButton(0))
        {

            if (Physics.SphereCast(DrawPlaceBrush.transform.position, 0.1f, DrawPlaceBrush.transform.forward, out RayHitInfo, 100f))
            {
                if (RayHitInfo.collider.tag == "CharacterCollides")
                {
                    this.transform.position = RayHitInfo.point;
                    GetComponent<TrailRenderer>().enabled = true;
                    RayHitInfo.collider.gameObject.SetActive(false);
                }
               
            }

            if (Physics.Raycast(DrawPlaceBrush.transform.position, DrawPlaceBrush.transform.forward, out RayHitInfo, 2.38f))
            {
                if (RayHitInfo.collider.tag == "Scroll")
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
          ResetLineRenderer();
        }
        
        
        Debug.DrawRay(DrawPlaceBrush.transform.position, DrawPlaceBrush.transform.forward,Color.green);

       

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
