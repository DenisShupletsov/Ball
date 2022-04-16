using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSphere : MonoBehaviour
{
    [SerializeField] private Transform sphereTransform;
    Vector3 origCameraPosition;

    void Start()
    {
        origCameraPosition = gameObject.transform.position;
    }

    void Update()
    {
        gameObject.transform.position = sphereTransform.position + origCameraPosition;
    }
}
