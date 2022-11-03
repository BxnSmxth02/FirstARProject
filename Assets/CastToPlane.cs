using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class CastToPlane: MonoBehaviour
{
    public GameObject QR_Code_Prefab;
    public ARRaycastManager raycastManager;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Update()
    {
        if (Input.touchCount < 0 || Input.GetMouseButtonDown(0))
        {
            if(raycastManager.Raycast(Input.touches[0].position, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
            {
                Instantiate(QR_Code_Prefab, hits[0].pose.position, Quaternion.identity);
            }
        }
    }
}
