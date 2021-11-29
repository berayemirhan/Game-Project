using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject TargetObject;
    public Vector3 cameraOffset;
    void LateUpdate()
    {
        transform.position = TargetObject.transform.position;
    }
}
