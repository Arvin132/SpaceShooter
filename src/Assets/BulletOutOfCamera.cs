using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOutOfCamera : MonoBehaviour {
    // Start is called before the first frame update
    private Camera mainCamera;
    private Collider2D objectCollider;

    void Start() {
        mainCamera = Camera.main;
        objectCollider = GetComponent<Collider2D>();    
    }

    // Update is called once per frame
    void Update() {
        // if (!objectIsVisible()) {
        //     // Destroy(gameObject);
        // }
    }

    // bool objectIsVisible() {
    //     Vector3 objectViewportPos = mainCamera.WorldToViewportPoint(transform.position);
    //     Bounds objectBounds = objectCollider.bounds;
    //     Vector3 objectWorldPos = transform.position;
    //     bool isObjectVisible =
    //         objectViewportPos.x > 0 && objectViewportPos.x < 1 &&
    //         objectViewportPos.y > 0 && objectViewportPos.y < 1 &&
    //         objectWorldPos.z > mainCamera.nearClipPlane &&
    //         objectWorldPos.z < mainCamera.farClipPlane &&
    //         objectBounds.min.x < mainCamera.ViewportToWorldPoint(Vector3.one).x &&
    //         objectBounds.max.x > mainCamera.ViewportToWorldPoint(Vector3.zero).x &&
    //         objectBounds.min.y < mainCamera.ViewportToWorldPoint(Vector3.one).y &&
    //         objectBounds.max.y > mainCamera.ViewportToWorldPoint(Vector3.zero).y;

    //     return isObjectVisible;
    // }
}
