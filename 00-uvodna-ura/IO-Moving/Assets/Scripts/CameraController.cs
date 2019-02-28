using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;
    [Range(0.0f,1.0f)]
    [SerializeField] float lerpFactor;

    // Update is called once per frame
    void FixedUpdate() {
        Vector3 cameraPos = player.position;
        cameraPos += offset;
        cameraPos = Vector3.Lerp(transform.position,cameraPos, lerpFactor);

        transform.position = cameraPos;
    }
}
