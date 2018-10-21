using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceManager : MonoBehaviour {

    List<DetectedPlane> NewPlanes = new List<DetectedPlane>();

    void Update()
    {
        if (Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        Session.GetTrackables(NewPlanes, TrackableQueryFilter.New);

        foreach (var plane in NewPlanes)
        {
            var surfaceObj = new GameObject("ChemViewSurface");
            surfaceObj.transform.tag = "ChemViewSurface";
            var arCoreSurface = surfaceObj.AddComponent<Surface>();
            arCoreSurface.SetTrackedPlane(plane);
        }
    }
}
