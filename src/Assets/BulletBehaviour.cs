using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {
    public float destroyDelay = 5f;
    private float speed = 10f;
    private Vector2 direction = Vector2.right;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() {
        Destroy(gameObject, destroyDelay);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        transform.position += (Vector3)direction * speed * Time.deltaTime;

    }

    public void setSpeed(float given) {
        speed = given;
    }
    
    public void setDirection(Vector2 given) {
        direction = given;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
