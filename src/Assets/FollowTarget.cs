using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {
    public GameObject target;
    public float moveSpeed;
    public float rotationSpeed;
    private Vector3 rotationDirection;

    // Start is called before the first frame update
    void Start() {
        if (Random.Range(0, 2) == 1) {
            rotationDirection = Vector3.forward;
        } else {
            rotationDirection = Vector3.back;
        }
    }

    // Update is called once per frame
    void Update() {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        transform.Rotate(rotationDirection, rotationSpeed * Time.deltaTime);
    }
}
