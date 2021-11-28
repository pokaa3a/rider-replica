using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    Vector3 offset = new Vector3(7.1f, 2f, 0f);

    void LateUpdate()
    {
        Vector3 newPos = target.position + offset;
        newPos.z = transform.position.z;

        transform.position = newPos;
    }
}
